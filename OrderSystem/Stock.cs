using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace OrderSystem
{
    public class Stock
    {
        private BindingList<Category> _categoryList = new BindingList<Category>();
        private readonly string[] _productCategoryName = { "主機板", "CPU", "記憶體", "硬碟", "顯示卡", "套裝電腦" };
        private readonly string[,] _productImagePath =
            { { "MB01.jpg","MB02.jpg","MB03.jpg","MB04.jpg","MB05.jpg","MB06.jpg","MB07.jpg","MB08.jpg","MB09.jpg" },
            { "cpu01.jpg","cpu02.jpg","cpu03.jpg","cpu04.jpg","cpu05.jpg","cpu06.jpg","cpu07.jpg","cpu08.jpg","cpu09.jpg" },
            { "ram01.jpg","ram02.jpg","ram03.jpg","ram04.jpg","ram05.jpg","ram06.jpg","ram07.jpg","ram08.jpg","ram06.jpg" },
            { "hdd01.jpg","hdd02.jpg","hdd03.jpg","hdd04.jpg","hdd05.jpg","hdd06.jpg","hdd07.jpg","hdd08.jpg","hdd09.jpg" },
            { "vga01.jpg","vga02.jpg","vga03.jpg","vga04.jpg","vga05.jpg","vga06.jpg","vga07.jpg","vga08.jpg","vga09.jpg" },
            { "comset01.jpg","comset02.jpg","comset03.jpg","comset04.jpg","comset05.jpg","comset06.jpg","comset07.jpg","comset08.jpg","comset09.jpg" } };
        private readonly string[,] _productNameList =
            { { "ASUS Z87-DELUX",
                "ASUS P8Z68-DELUX",
                "GIGABYTE MA78G-CS3H",
                "ASUS P7P55-M",
                "MSI DM7-SL52",
                "ASUS H97-PRO GAMER",
                "ASUS PRIME Z390-P ",
                "GIGABYTE Z390 AORUS MASTER",
                "GIGABYTE GA-E3000N" },
            { "Intel Petium",
                "Intel Core i3 9th",
                "Intel Core i5 9th",
                "Intel Core i7 9th",
                "Intel Core i9 9th",
                "Intel Xeon Gold",
                "AMD Ryzen 5-3600 3.6GHz",
                "AMD Ryzen 7-3800X 3.9GHz",
                "AMD Ryzen 5-2600 3.4GHz" },
            { "HP DDR3 8G 1600",
                "HP DDR3 16G 1600",
                "Kingston DDR4L 8G 1600",
                "Kingston DDR4L 16G 1600",
                "SAMSUNG DDR4 16G 2666",
                "Crucial DDR4 16G 2666",
                "Micron Ballistix Sport 16G",
                "ADATA XPG Z1 DDR4 3000 8G",
                "Transcend 8GB JetRam DDR4 2666" },
            { "Kingston HDD 1TB",
                "WD HDD 500G",
                "SAMSUNG HDD 1TB",
                "WD SSD PCIE 250G",
                "WD SSD PCIE 500G",
                "SAMSUNG SSD PCIE 500G",
                "Toshiba Canvio Basics 2TB",
                "WD My Passport 1TB 2.5吋",
                "TOSHIBA Canvio Advance V9 2TB" },
            { "MSI GTX1080Ti ARMOR DDR5 8G",
                "ASUS STRIX-RTX2080-O11G-GAMING",
                "ASUS ROG-STRIX-RTX2060-O6G",
                "MSI GeForce GTX 1060 ARMOR 3G OCV1",
                "MSI GeForce GTX 960",
                "MSI GeForce 980Ti",
                "AORUS GeForce RTX 2080 SUPER 8G",
                "ASUS ROG STRIX RX5700XT O8G GAMING",
                "MSI Radeon RX 580 ARMOR 8G OC " },
            { "Gigabyte Brand Computer Set",
                "ASUS Brand Computer Set",
                "Lenovo Brand Computer Set",
                "HP Brand Computer Set",
                "Sony Brand Computer Set",
                "Acer Brand Computer Set",
                "Intel NUC8i3BEH-0824N",
                "Intel NUC8i7BEH-0824N",
                "技嘉Z390平台 I9八核RTX2080Ti獨顯電玩機" } };
        private readonly string[,] _productDescriptionList =
            { { "適用於第四代 haswell intel處理器 ★使用 intel b85 晶片組 ★pcie 3.0 傳輸速度加快 ★epu省電引擎 能降低風扇噪音",
                "Z68芯片組系列的中檔型號配備PCI-Express 3.0插槽產品名稱由華碩製造■ATX主板■P8Z68-V PRO / GEN3 LGA 1155■型號P8Z68-V PRO / GEN3規格外形",
                "內建雙核心amd e2-3000 及radeon™ hd 8280內建顯示處理器 ◆2組ddr3插槽，支援單通道技術及non-ecc記憶體 ◆顯示輸出:1 x hdmi 1 x d-sub ◆pcb",
                "◆ 支援cpu ：1151腳位(intel 8代) ◆ 記憶體 ：2x dimm 32gb ddr4(max) ◆ 擴充插槽：1x pcie 3.0 2",
                "★optimem ii技術 支援4dimm ddr4超頻4266，相容性穩定性最佳 ★procool實心電源接頭、提供最佳超頻電源供應 ★1*4pin rgb針腳 ★gpu溫度",
                "華碩 PRIME Z390-P 主機板 ★optimem ii技術 支援4dimm ddr4超頻4266，相容性穩定性最佳 ★procool實心電源接頭、提供最佳超頻電源供應 ★1*4pin rgb針腳 ★gpu溫度偵測功能 ",
                "送★《技嘉週邊》技嘉 Z390 AORUS MASTER 主機板 ◆ 支援cpu ：1151腳位(intel 8代) ◆ 記憶體 ：4x dimm 64gb ddr4(max) ◆ 顯示輸出：1x hdmi ◆",
                "★ai智能超頻，主動判斷cpu體質與散熱條件，提供客製化的最佳超頻設定 ★optimem ii技術 支援4dimm ddr4超頻4266，相容性穩定性最佳",
                "技嘉 GA-E3000N 主機板 ◆內建雙核心amd e2-3000 及radeon™ hd 8280內建顯示處理器 ◆2組ddr3插槽，支援單通道技術及non-ecc記憶體" },
            { "Intel Petium 中央處理器 ˙第九代 intel 處理器˙ ◆ 腳位：1151 ◆ 基礎頻率：2.60 ghz ◆ 快取記憶體：4 mb ◆ 核心 執行緒: 3 3 ",
                "Intel Core i3-9100F 中央處理器 ˙第九代 intel 處理器˙ ◆ 腳位：1151 ◆ 基礎頻率：3.60 ghz ◆ 快取記憶體：6 mb ◆ 核心 執行緒: 4 4 ◆ tdp：65 w",
                "Intel 盒裝 Core i5-9400F ◆ 腳位：1151 ◆ 時脈速度：2.90-4.10 ghz ◆ 快取記憶體：9mb ◆ 核心 執行緒：6 6 ◆ tdp：65 w",
                "Intel 盒裝Core i7-9700K ˙第九代 intel 處理器˙ ◆ 腳位：1151 ◆ 基礎頻率：3.60 ghz ◆ 快取記憶體：12 mb ◆ 核心 執行緒：8 8 ◆ 內含顯示：hd graphics 630",
                "Intel 盒裝Core i9-9900K ˙第九代 intel 處理器˙ ◆ 腳位：1151 ◆ 時脈速度：3.60-5.00 ghz ◆ 核心 執行緒：8 16 ◆ 內含顯示：hd graphics 630 ◆",
                "Intel Xeon 黃金級 5115 中央處理器 ◆ 腳位： fclga3647 ◆ 時脈速度： 2.4 ghz 最大超頻: 3.2 ghz ◆ 核心 執行緒：10 20 ◆ 快取記憶體： 13.75 mb l3 ◆",
                "硬起來★送《XBOX會籍》AMD Ryzen 5-3600 3.6GHz六核心 中央處理器 amd r5-3600 六核心處理器 cpu 核心數: 6 基本時脈速度: 3.6ghz ",
                "★送《XBOX遊戲會籍》AMD Ryzen 7-3800X 3.9GHz 八核心 中央處理器 cpu 核心數: 8 線程：16 基本時脈速度: 3.9ghz 最大渦輪核心速度: 4.5ghz ",
                "AMD Ryzen 5-2600 3.4GHz 六核心 中央處理器 cpu 核心數: 6 線程：12 基本時脈速度: 3.4ghz 最大渦輪核心速度: 3.9ghz" },
            { "8GB DDR3 1333 桌上型記憶體(KVR1333D3N9/8G) ★桌上型電腦專用 ★規格：ddr3-1333 ★容量：8gb ★針腳：240-pin",
                "16GB DDR3 1333 桌上型記憶體(KVR1333D3N9/8G) ★桌上型電腦專用 ★規格：ddr3-1333 ★容量：8gb ★針腳：240-pin",
                "超頻記憶體 不對稱切割設計散熱片 完整包覆性高效鍛造式熱傳導散熱片 超低工作電壓1.2v~1.4v 支援xmp2.0一鍵超頻 終身保固",
                "超頻記憶體 不對稱切割設計散熱片 完整包覆性高效鍛造式熱傳導散熱片 超低工作電壓1.2v~1.4v 支援xmp2.0一鍵超頻 終身保固",
                "三星 DDR4 2666 16G 超頻電競筆記型記憶體 ▼韓國職業電競團體首選▼ ● hynix原廠晶圓 ● cl值 16-18-18 ● 終身有限保固 科賦不為人知秘辛揭露！",
                "Micron Crucial NB-DDR4 2400/16G RAM 美光(micron)原廠正品貨 嚴選micron頂級顆粒 100%原裝進口 100%產品測試 以及100%相容性之保證",
                "Micron Ballistix Sport LT競技版 D4 3000/ 16G RAM超頻記憶體(白色散熱片) ◆15-16-16 ◆工作電壓1.35伏特 ◆終身保固 ◆",
                "ADATA威剛 XPG Z1 DDR4 3000 8G超頻RAM ◆傳輸速度高達3000mhz，工作頻寬可達每秒26.6gb ◆由原本的1.5v降至1.35v ◆採用獨特的熱傳導技術",
                "【Transcend 創見】8GB JetRam DDR4 2666 桌上型記憶體(JM2666HLB-8G) ● 桌上型專用long-dimm ● 規格 : ddr4-2666mhz ●" },
            { "金士頓 Kingston A1000 960GB M.2 2280 PCIe NVMe™ Gen 3.0x2 SSD 固態硬碟(SA1000M8/960G) 讀1500m 寫1000m 3d tlc 五年保",
                "WD 25S3 USB3.1 2.5吋SSD/HDD外接盒 ● usb 3.1 gen 1極速傳輸介面 ● 適用於9.5毫米內的2.5吋hdd及ssd ● 簡易安裝，隨插即用",
                "SAMSUNG 三星 T5 1TB USB3.1 移動固態硬碟 炫英黑 採用三星v-nand技術，傳輸和備份更敏捷更快速 傳輸速度高達540mb s，比hdd快高達4.9倍 重量僅51g，尺寸比名片還小 採用aes 256位硬體加密",
                "新上市💰電競升級攻略 WD 黑標 SN750 250GB NVMe PCIe SSD固態硬碟(WDS250G3X0C) 讀3100m 寫1600m 五年保 ◆連續讀取3100mb s，連讀寫入1600mb s ◆發揮系統極致效能",
                "WD 藍標 SN500 250GB NVMe PCIe SSD固態硬碟(WDS250G1B0C) 讀1700m 寫1300m 五年保 ◆連續讀取1700mb s，連讀寫入1300mb s ◆發揮系統極致效能",
                "SAMSUNG 三星 970 EVO Plus 1TB NVMe M.2 PCIe SSD固態硬碟 最高讀取3 500mb s，最高寫入3 300mb s ■ 最新v-nand技術和優化，速度更快",
                "▼每日強檔‧瘋殺特賣▼Toshiba Canvio Basics 黑靚潮lll 2TB 2.5吋行動硬碟 《限時狂降★週一10點回價》",
                "WD My Passport 1TB 2.5吋行動硬碟(靚黑) ★硬體加密保護 ★極速傳輸usb3.0 ★輕巧身形好攜帶 時尚外型 ★支援dropbox雲端備份 ★256 位元硬體加密 ",
                "TOSHIBA Canvio Advance V9 2TB 2.5吋行動硬碟-罌紅 ★高速usb3.0傳輸 ★超輕薄1.4cm厚度 ★led指示燈 ★外型四點圓弧 ★特殊咬合設計 ★首次使用玻璃片的硬碟 " },
            { "◆ 顯示晶片 ：NVIDIA GeForce GTX 1080Ti ◆ 記憶體 ：8GB GDDR5X ◆ CUDA數 ：2560 ◆ 核心時脈 ：1607 MHz ◆ 記憶體時脈：10010 MHz ◆ 記憶體介面：256-bit",
                "送★《現代戰爭》華碩 ROG Strix GeForce RTX™ 2080 O11G GAMING 顯示卡 ◆ 顯示晶片：nvidia® geforce® rtx 2080 ti ◆ 記憶體：11gb gddr6 ◆ 核心時脈：1",
                "送★《現代戰爭》華碩 GeForce RTX 2060 SUPER GAMING X 顯示卡 ◆ 顯示晶片 ：nvidia® geforce® rtx 2060 super ◆ 記憶體 ：8gb gddr6 ◆",
                "微星 GTX 1060 ARMOR 3G OCV1 顯示卡 (Gaming虎) ◆ 顯示晶片 ：nvidia geforce gtx 1060 ◆ 記憶體 ：3gb gddr5 ◆ 核心時脈 ：1544 mhz ◆",
                "MSI 製グラボ GTX 960 GAMING 2G PCIExp 2GB",
                "MSI 製グラボ GTX 980Ti GAMING 4G PCIExp 4GB",
                "★《現代戰爭+邊緣禁地》技嘉 AORUS GeForce RTX 2080 SUPER 8G 顯示卡 ◆ 顯示晶片 ：geforce® rtx 2080 super™ ◆ 記憶體 ：8gb gddr6 ◆",
                "送★遊戲二選一華碩 ROG STRIX RX5700XT O8G GAMING 顯示卡 ◆ 顯示晶片 ：amd radeon rx 5700 xt ◆ 記憶體 ：8gb gddr6 ◆",
                "送★遊戲二選一微星 Radeon RX 580 ARMOR 8G OC 顯示卡(Gaming虎) ◆顯示晶片：amd radeon rx 580 ◆記憶體：8gb gddr5 ◆晶片核心時脈：1366 mhz ◆" },
            { "技嘉Z390平台「龍馬狼神」I9八核RTX2080Ti獨顯電玩機 處理器：intel core i9-9900k 八核心處理器 散熱器：搭載 bykski inr240-wcol rgb一體式水冷散熱器 ",
                "華碩Z390平台「惡龍鬥神」I9八核RTX2080獨顯電玩機 處理器：intel core i7-9700k 八核心處理器 散熱器：搭載 bykski inr240-wcol rgb一體式水冷散熱器 ",
                "•業界唯一 All Intel Inside •全球第一台 Microsoft Azure AI 智慧筆電 •第九代Intel Core i9/i7 處理器 •NVIDIA GeForce RTX 20系列獨顯 •首創3mm微邊框 + X-Rite™ Pantone®校色認證 •三星Samsung 原廠記憶體模組 •Nahimic 3 環繞音效技術 •Killer Networking 頻寬管理技術 #GameFast",
                "《獨特無風扇設計》《高質感工業精緻設計》 ● 一個優雅而精緻的全鋁製機殼 ● 與mini-ITX主板兼容 ● 被動冷卻CPU和電源 ● 專為高效無風扇冷卻而設計 * 套裝組合包括Streacom DB4機殼、ZeroFlex 240W電源供應器、LH6散熱套件",
                "intel NUC8i7BEH-0824N 迷你電腦(i7-8559U/8G/240G SSD) 注意事項:本機需加裝升級配件，因此需會做開機檢測動作，可接受者方可下單 處 理 器：intel® core™ i7-8559u 記 憶 體",
                "注意事項:本機需加裝升級配件，因此需會做開機檢測動作，可接受者方可下單 處 理 器：Intel® Core™ i7-8559U 記 憶 體：8G DDR4(MAX 32G) 硬碟：240G SSD 顯示晶片：Intel® Iris™ Plus Graphics 655 網 路：10/100/1000 Mbps 無線網路：Intel® Wireless-AC 9560 + Bluetooth 5.0",
                "Intel NUC8i3BEH-0824N 迷你電腦(i3-8109U/8/G/240G SSD) 注意事項:本機需加裝升級配件，因此需會做開機檢測動作",
                "Intel NUC8i7BEH-0824N 迷你電腦(i7-8559U/8G/240G SSD) 注意事項:本機需加裝升級配件，因此需會做開機檢測動作，可接受者方可下單",
                "技嘉Z390平台「龍馬狼神」I9八核RTX2080Ti獨顯電玩機 處理器：intel core i9-9900k 八核心處理器 散熱器：搭載 bykski inr240-wcol rgb一體式水冷散熱器 " } };
        private readonly int[,] _productPriceList =
            { { 1380,1560,1890,1410,1990,1790,1660,1530,1440 },
                { 990,1850,2650,4550,8890,18100,5690,8880,9990 },
                { 750,1490,950,1950,1890,1990,1999,1650,1280 },
                { 1790,850,1650,2180,2290,1550,2188,1750,1330 },
                { 27590,39890,10990,4590,3890,8990,17980,16590,22990 },
                { 23890,24550,27790,28590,33590,30190,33390,45890,50390 } };
        private readonly int[,] _productQuantityList =
            { { 10,11,20,21,15,8,33,16,18 },
                { 0,50,33,20,15,36,41,66,77 },
                { 2,18,50,40,44,33,22,11,35 },
                { 60,50,40,0,20,15,10,5,0 },
                { 25,35,45,55,65,75,85,60,22 },
                { 10,9,8,7,6,5,6,4,8 } };

        public Stock()
        {
            for (int i = 0; i < Constant.SIX; i++)
            {
                _categoryList.Add(new Category(_productCategoryName[i]));
                for (int j = 0; j < Constant.NINE; j++)
                {
                    _categoryList[i].AddNewProduct(new Product(_productNameList[i,j], _productDescriptionList[i,j], _productPriceList[i,j], _productQuantityList[i,j], _productImagePath[i,j]));
                }
            }
        }
        public BindingList<Category> ProductList
        {
            get
            {
                return _categoryList;
            }
        }

        //取得商品名稱
        public string GetProductName(int category, int product)
        {
            return _categoryList[category].GetProductName(product);
        }

        //取得商品分類
        public string GetProductDescription(int category, int product)
        {
            return _categoryList[category].GetProductDescription(product);
        }

        //取得商品價格
        public int GetProductPrice(int category, int product)
        {
            return _categoryList[category].GetProductPrice(product);
        }

        //取得商品庫存數量
        public int GetProductStockQuantity(int category, int product)
        {
            return _categoryList[category].GetProductStockQuantity(product);
        }

        //取得商品圖片路徑
        public string GetProductImagePath(int category, int product)
        {
            return _categoryList[category].GetProductImagePath(product);
        }

        //取得分類的數量
        public int GetCategoryCount()
        {
            return _categoryList.Count;
        }

        //取得每種分類中的商品數量
        public int GetProductCount(int category)
        {
            return _categoryList[category].ProductCount;
        }

        //取得商品分類名稱
        public string GetProductCategoryName(int category)
        {
            return _categoryList[category].CategoryName;
        }

        //設定商品名稱
        public void SetProductName(int category, int product, string name)
        {
            _categoryList[category].SetProductName(product, name);
        }

        //設定商品介紹
        public void SetProductDescription(int category, int product, string description)
        {
            _categoryList[category].SetProductDescription(product, description);
        }

        //設定商品價格
        public void SetProductPrice(int category, int product, int price)
        {
            _categoryList[category].SetProductPrice(product, price);
        }

        //設定商品圖片路徑
        public void SetProductImagePath(int category, int product, string path)
        {
            _categoryList[category].SetProductImagePath(product, path);
        }

        //設定商品分類名稱
        public void SetProductCategory(int category, string name)
        {
            _categoryList[category].SetProductCategory(name);
        }

        //補貨
        public void SupplyProduct(int category, int product, int number)
        {
            _categoryList[category].SetProductStockQuantity(product, number);
        }

        //新增商品
        public void AddNewProduct(int index, List<string> list, int quantity)
        {
            _categoryList[index].AddNewProduct(new Product(list[0], list[1], int.Parse(list[Constant.TWO]), quantity, list[Constant.THREE]));
        }

        //移除商品
        public void RemoveProduct(int index, int removeIndex)
        {
            _categoryList[index].RemoveProduct(removeIndex);
        }

        //新增類別
        public void AddNewCategory(string name)
        {
            _categoryList.Add(new Category(name));
        }
    }
}
