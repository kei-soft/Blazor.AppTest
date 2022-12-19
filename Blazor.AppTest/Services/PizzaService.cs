using Blazor.AppTest.Data;

namespace Blazor.AppTest.Services
{
    public class PizzaService
    {
        public Task<PizzaItem[]> GetPizzasAsync()
        {
            // Get DB Data
            PizzaItem[] pizzaItems = new PizzaItem[3];
            pizzaItems[0] = new PizzaItem() { PizzaId = 1, Name = "마스터 트리플 코드", Description = "디저트로 즐기는 피자", Price = 28000, Vegan = true, Vegetarian = true };
            pizzaItems[1] = new PizzaItem() { PizzaId = 2, Name = "치즈 퐁듀 파이어 미트", Description = "씨푸드 퐁듀 피자의 귀환", Price = 29000, Vegan = true, Vegetarian = true };
            pizzaItems[2] = new PizzaItem() { PizzaId = 3, Name = "블로버스터4", Description = "4개 도시의 프리미엄 요리를 품은 피자", Price = 29000, Vegan = true, Vegetarian = true };

            return Task.FromResult<PizzaItem[]>(pizzaItems);
        }
    }
}
