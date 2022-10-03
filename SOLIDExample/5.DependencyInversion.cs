namespace SOLIDExample
{

    public interface IBasketService
    {
        public Task Get(int id);
        public Task Create(int userId);
        public Task AddItem(int basketId, int productId);
        public Task RemoveItem(int basketId, int productId);
        public Task MarkAsResolved(int basketId);
    }

    public class BasketService : BaseService, IBasketService
    {
        private readonly IRepository _basketRepo;
        private readonly IRepository _productRepo;

        public BasketService(IUnitOfWork unitOfWork, IRepository basketRepo, IRepository productRepo) : base(unitOfWork)
        {
            _basketRepo = basketRepo;
            _productRepo = productRepo;
        }

        public async Task Get(int id)
        {
            //... detail
        }

        public async Task Create(int userId)
        {
            //... detail
        }

        public async Task AddItem(int basketId, int productId)
        {
            //... detail
        }

        public async Task RemoveItem(int basketId, int productId)
        {
            //... detail
        }

        public async Task MarkAsResolved(int basketId)
        {
            //... detail
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class BasketController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly BasketService _basketService;

        public BasketController(ILogger logger, BasketService basketService)
        {
            _logger = logger;
            _basketService = basketService;
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class BasketController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IBasketService _basketService;

        public BasketController(ILogger logger, IBasketService basketService)
        {
            _logger = logger;
            _basketService = basketService;
        }
    }
}
