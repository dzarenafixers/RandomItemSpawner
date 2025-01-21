using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.CustomItems.API.Features;
using UnityEngine;

namespace RandomItemSpawner.Handlers
{
    public static class ItemSpawner
    {
        public static void SpawnCustomItems(int spawnCount)
        {
            // قائمة بالعناصر المخصصة
            List<CustomItem> customItems = new List<CustomItem>
            {
                CustomItem.Get(4145854), // استبدل الرقم بمعرف العنصر المخصص
                CustomItem.Get(1452855),
                CustomItem.Get(999999),
                CustomItem.Get(88985),
                CustomItem.Get(78451),
                CustomItem.Get(9575),
                CustomItem.Get(9448),
                CustomItem.Get(8814),
                CustomItem.Get(8667),
                CustomItem.Get(7510),
                CustomItem.Get(2691),
                CustomItem.Get(2127),
                CustomItem.Get(1921),
                CustomItem.Get(474),



            };

            // قائمة تحتوي على جميع المواقع الممكنة (بما في ذلك الغرف المخفية)
            List<Vector3> roomPositions = new List<Vector3>
            {
                // الغرف الأساسية:
                new Vector3(10f, 0f, 10f),  // المدخل (Entrance Zone)
                new Vector3(20f, 0f, 20f),  // غرفة الحجز الخفيف (Light Containment Zone)
                new Vector3(30f, 0f, 30f),  // غرفة الحجز الثقيل (Heavy Containment Zone)
                new Vector3(40f, 0f, 40f),  // غرفة الأبحاث (Research Room)

                // غرف SCP:
                new Vector3(50f, 0f, 50f),  // SCP-173 (غرفة)
                new Vector3(60f, 0f, 60f),  // SCP-106 (غرفة)
                new Vector3(70f, 0f, 70f),  // SCP-049 (غرفة)
                new Vector3(80f, 0f, 80f),  // SCP-096 (غرفة)
                new Vector3(90f, 0f, 90f),  // SCP-939 (غرفة)

                // الغرف المخبأة:
                new Vector3(150f, 0f, 150f),  // غرفة سرية (Hidden Room)
                new Vector3(160f, 0f, 160f),  // منطقة مخفية (Secret Zone)
                new Vector3(170f, 0f, 170f),  // غرفة تحت الأرض (Underground Room)
                new Vector3(180f, 0f, 180f),  // غرفة الوصول المحدود (Restricted Access Room)
                new Vector3(190f, 0f, 190f),  // غرفة اختفاء (Disappearing Room)

                // أماكن مخفية إضافية:
                new Vector3(200f, 0f, 200f),  // مختبرات سابقة (Abandoned Labs)
                new Vector3(210f, 0f, 210f),  // غرفة تجريبية قديمة (Old Test Room)
                new Vector3(220f, 0f, 220f),  // غرفة محفوظة (Preserved Room)
                new Vector3(230f, 0f, 230f),  // مختبرات SCP المظلمة (Dark SCP Labs)
                new Vector3(240f, 0f, 240f),  // منطقة تحت الأرض (Underground Area)
                
                // المزيد من الغرف المخفية:
                new Vector3(250f, 0f, 250f),  // غرفة محمية (Secure Room)
                new Vector3(260f, 0f, 260f),  // منطقة تخزين محجوزة (Reserved Storage)
                new Vector3(270f, 0f, 270f),  // غرفة قديمة جدا (Very Old Room)
                new Vector3(280f, 0f, 280f),  // غرفة أساسية مهجورة (Abandoned Core Room)
                new Vector3(290f, 0f, 290f),  // غرفة تخزين سرية (Secret Storage Room)

                // غرف SCP أخرى:
                new Vector3(300f, 0f, 300f),  // غرفة SCP-914 (SCP-914 Room)
                new Vector3(310f, 0f, 310f),  // غرفة SCP-079 (SCP-079 Room)
                new Vector3(320f, 0f, 320f),  // غرفة الاختبار SCP (SCP Testing Room)

                // مناطق أخرى على الخريطة:
                new Vector3(330f, 0f, 330f),  // غرفة التفتيش (Inspection Room)
                new Vector3(340f, 0f, 340f),  // المنطقة السرية (Top Secret Area)
                new Vector3(350f, 0f, 350f),  // غرفة الأبحاث المحظورة (Restricted Research Room)
                new Vector3(360f, 0f, 360f),  // غرفة التحكم (Control Room)
                new Vector3(370f, 0f, 370f),  // غرفة التفاعل (Interaction Room)

                // المزيد من الأماكن المخفية:
                new Vector3(400f, 0f, 400f),  // غرفة اختبار سرية (Secret Test Room)
                new Vector3(410f, 0f, 410f),  // غرفة مبطنة (Soundproof Room)
                new Vector3(420f, 0f, 420f),  // غرفة متاهة (Maze Room)
                new Vector3(430f, 0f, 430f),  // غرفة رصد سرية (Secret Observation Room)
                new Vector3(440f, 0f, 440f),  // ممر مظلم (Dark Corridor)
                
                // غرف معروفة وذات فائدة خاصة:
                new Vector3(450f, 0f, 450f),  // غرفة الخوادم (Server Room)
                new Vector3(460f, 0f, 460f),  // منطقة الكهرباء (Electricity Zone)
                new Vector3(470f, 0f, 470f),  // غرفة القياس (Measurement Room)
                new Vector3(480f, 0f, 480f),  // غرفة المحاكاة (Simulation Room)
                new Vector3(490f, 0f, 490f),  // غرفة الاحتجاز الخاصة (Special Containment Room)
                
                // مناطق تفاعل إضافية:
                new Vector3(500f, 0f, 500f),  // غرفة القيود (Lockdown Room)
                new Vector3(510f, 0f, 510f),  // منطقة الخوف (Fear Zone)
                new Vector3(520f, 0f, 520f),  // غرفة تخزين مخفية (Hidden Storage Room)
                new Vector3(530f, 0f, 530f),  // غرفة مضادة (Counter Room)

                // إضافة المزيد من الغرف المخفية في المواقع الأكثر تحديًا:
                new Vector3(540f, 0f, 540f),  // غرفة محكمة (Trial Room)
                new Vector3(550f, 0f, 550f),  // غرفة الفضاء (Void Room)
                new Vector3(560f, 0f, 560f),  // مختبر التجارب العليا (High Experiment Lab)
                new Vector3(570f, 0f, 570f),  // غرفة الطبقة المتقدمة (Advanced Layer Room)
                new Vector3(580f, 0f, 580f),  // غرفة التخزين الأساسية (Main Storage Room)
                new Vector3(590f, 0f, 590f),  // غرفة البيئة القاسية (Harsh Environment Room)

                // غرف ضيقة أو متاهة:
                new Vector3(600f, 0f, 600f),  // غرفة المتاهة السرية (Secret Maze Room)
                new Vector3(610f, 0f, 610f),  // غرفة الأبحاث السرية (Secret Research Room)
                new Vector3(620f, 0f, 620f),  // غرفة الفيروسات المخفية (Hidden Virus Room)
                new Vector3(630f, 0f, 630f),  // غرفة الوقود (Fuel Room)
                new Vector3(640f, 0f, 640f),  // غرفة الحماية (Protection Room)
                new Vector3(650f, 0f, 650f),  // غرفة العزلة (Isolation Room)

                // الغرف الأكثر خطورة:
                new Vector3(660f, 0f, 660f),  // غرفة الألغام (Mine Room)
                new Vector3(670f, 0f, 670f),  // غرفة الطاقة النووية (Nuclear Power Room)
                new Vector3(680f, 0f, 680f),  // غرفة التفاعلات المتقدمة (Advanced Reaction Room)
                new Vector3(690f, 0f, 690f),  // غرفة النظام المغلق (Closed System Room)
                new Vector3(700f, 0f, 700f),  // غرفة الضغط العالي (High Pressure Room)
            };

            // التأكد من وجود عناصر مخصصة في القائمة
            if (customItems.Count == 0 || roomPositions.Count == 0)
            {
                Log.Warn("لا توجد عناصر مخصصة أو غرف لتوليد العناصر.");
                return;
            }

            // توليد العناصر العشوائية في المواقع المحددة
            for (int i = 0; i < spawnCount; i++)
            {
                // اختر عنصرًا عشوائيًا
                CustomItem randomItem = customItems[UnityEngine.Random.Range(0, customItems.Count)];

                // اختر موقع غرفة عشوائي من القائمة
                Vector3 randomPosition = roomPositions[UnityEngine.Random.Range(0, roomPositions.Count)];

                // توليد العنصر في الموقع المحدد
                randomItem.Spawn(randomPosition);

                Log.Info($"تم توليد العنصر {randomItem.Name} في الموقع: {randomPosition}");
            }
        }
    }
} 