using healthy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace healthy.ViewModels
{
    class HomeViewModel
    {
        public ObservableCollection<FoodModel> ProductData { get; set; }
        public HomeViewModel()
        {
            ProductData = new ObservableCollection<FoodModel>(new List<FoodModel>
            {   new FoodModel{Price="9",TitleItem="Burger"            ,ContentItem="Món ăn gồm: thịt, rau, cà chua, nước sốt "     ,ColorItem="#F2E1C1",ImageItem="burger.png" },
                new FoodModel{Price="12",TitleItem="Khoai Tây Chiên " ,ContentItem="Món ăn chỉ có khoai Tây "                      ,ColorItem="#F2E1C1",ImageItem="french_fries.png"},
                new FoodModel{Price="15",TitleItem="HotDog"           ,ContentItem="Món ăn bao gồm: bánh mỳ,xúc xích, tương ớt "    ,ColorItem="#F2E1C1",ImageItem="hotdog.png"},
                new FoodModel{Price="5" ,TitleItem="Mỳ Sợi"            ,ContentItem="Món ăn bao gồm: mỳ sợi ,các toping như: trứng,thịt bò, xúc xích ",ColorItem="#F2E1C1",ImageItem="noodles.png"},
                new FoodModel{Price="20",TitleItem="Sườn nướng "       ,ContentItem="Món ăn bao gồm: Sườn bò,heo ướp gia vị ăn kèm với nước sốt "      ,ColorItem="#F2E1C1",ImageItem="meat.png"},
                new FoodModel{Price="10",TitleItem="Bia "              ,ContentItem="Thức Uống Lúa Mạch "                      ,ColorItem="#F2E1C1",ImageItem="six_pack.png"},
                new FoodModel{Price="20",TitleItem="Sandwich "         ,ContentItem="Món ăn bao gồm: bánh mỳ sandwich, cà chua, pate, cà chua"  ,ColorItem="#F2E1C1",ImageItem="sandwich.png"},
                new FoodModel{Price="15",TitleItem="Bánh Donut " ,ContentItem="Món ăn bao gồm: bánh hình tròn được phủ nhiều vị khác nhau như: phô mai ,socola,dâu "          ,ColorItem="#F2E1C1",ImageItem="donut.png"},
                new FoodModel{Price="10",TitleItem="COCACOLA " ,ContentItem="Thức uống có gas "                      ,ColorItem="#F2E1C1",ImageItem="cola.png"},
                new FoodModel{Price="3",TitleItem="Kem  " ,ContentItem="Món ăn bao gồm: có rất nhiều vị để lựa chọn như:Đào, việt quất, Dưa Lưới "  ,ColorItem="#F2E1C1",ImageItem="ice_cream.png"},
            });
        }
    }
}
