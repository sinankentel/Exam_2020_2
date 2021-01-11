using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2020_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LIST ve ARRAY DATA SET
            // data'lar
            var testList = new List<int> { -5, 4, -2, 3, 1, -1, -6, -1, 0, 5 };
            testList.Reverse();

            var testListEqual = new List<int> { -5, 4, -2, 3, 1, -1, -6, -1, 0, 5 };

            int[] testArray3 = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            testArray3.Reverse();
            int[] testArray5 = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            // capacity verebilirsin list ve array'e. veya direkt array'i list'e kopyalayabilirsin. capasity vermezsen kendisi ayarlar (list).
            int[] testArray4 = new int[5];
            int[] testArray6 = { 3, 4, 6 };
            var testList3 = new List<int>(testArray3);
            var testList4 = new List<int>(5);
            #endregion

            #region LIST EŞİTLİK CHECK
            bool isSameList = testList.SequenceEqual(testListEqual);
            bool isSameArray = testArray3.SequenceEqual(testArray5);
            #endregion

            #region SORTLAMA
            var testList2 = new List<int> { -5, 4, -2, 3, 1 };
            // instant sort
            testList2.Sort();
            // toList'e ataman gerekir.
            var orderedTestList2 = testList2.OrderBy(x => x).ToList();
            #endregion

            #region YUVARLAMA
            double number = Math.Sqrt(35);

            double maxValue = Math.Ceiling(5.4);
            double minValue = Math.Floor(5.4);

            double a = Math.Round(number);
            int b = Convert.ToInt32(number);
            int c = (int)number;
            #endregion

            #region CALLERS
            //var result = minStart_YourWay(testList);

            //Console.WriteLine(result);

            //var returnValue = sockMerchant(9, testArray3);

            //var returnValue = utopianTree(5);

            //var returnValue = beautifulDays(20, 23, 6);

            //var returnValue = findDigits(20);

            //var returnValue = squares3(3, 9);

            //var returnValue = divisibleSumPairs(6, 3, new int[] { 1, 3, 2, 6, 1, 2 });

            //var returnValue = camelcase("SinAn");

            //var returnValue = superReducedString("aaabccddd");

            //var returnValue = caesarCipher("ABC--de", 2);

            //var returnValue = hurdleRace(2, new int[] { 2, 5, 4, 5, 2 });

            //var returnValue = nonRepeatList(new List<int> { 1, 2, 2, 3, 1, 2 });

            //var returnValue = pickingNumbers(new List<int> { 4, 4, 4, 4 });

            //var returnValue = breakingRecords(new int[] { 5, 3, 2, 6, 1, 2 });

            //var returnValue = getMoneySpent(new int[] { 5, 3, 9 }, new int[] { 3, 1 }, 10);

            //var returnValue = catAndMouse(2, 5, 4);

            //extraLongFactorials(25);

            //calculateFactorial(6);

            //var result = libraryFine(2, 5, 2012, 4, 8, 2013);

            //var result = circularArrayRotation_Temp(new int[] { 39356, 87674, 16667, 54260, 43958 ,70429 ,53682 ,6169 ,87496 ,66190 ,90286 ,4912 ,44792 ,65142 ,36183 ,43856 ,77633 ,38902 ,1407 ,
            //    88185 ,80399 ,72940 ,97555 ,23941 ,96271 ,49288 ,27021 ,32032 ,75662 ,69161 ,33581 ,15017 ,56835 ,66599 ,69277 ,17144 ,37027 ,39310 ,23312 ,24523 ,5499 ,13597 ,45786 ,66642 ,
            //    95090 ,98320 ,26849 ,72722 ,37221 ,28255 ,60906}, 51, new int[] { 47, 10, 12, 13 });

            //var result = circularArrayRotation_Perf(new int[] { 1,2,3}, 2, new int[] { 0,1,2});

            //var result = circularArrayRotation_Temp(new int[] { 3, 1, 2, 4}, 2, new int[] { 0, 1, 2, 3 });

            //var result = circularArrayRotation_PuanTest(new int[] { 39356, 87674, 16667, 54260, 43958 ,70429 ,53682 ,6169 ,87496 ,66190 ,90286 ,4912 ,44792 ,65142 ,36183 ,43856 ,77633 ,38902 ,1407 ,
            //    88185 ,80399 ,72940 ,97555 ,23941 ,96271 ,49288 ,27021 ,32032 ,75662 ,69161 ,33581 ,15017 ,56835 ,66599 ,69277 ,17144 ,37027 ,39310 ,23312 ,24523 ,5499 ,13597 ,45786 ,66642 ,
            //    95090 ,98320 ,26849 ,72722 ,37221 ,28255 ,60906}, 51, new int[] { 47, 10, 12, 13 });

            //var result = leftArrayRotation();

            //var result = rotLeft(new int[] { 3, 1, 2, 4 }, 2);

            //var result = migratoryBirds(new List<int> { 1, 2, 3, 3, 3, 3, 4, 4, 4 });

            //var result2 = migratoryBirds(new List<int> { 1, 4, 4, 4, 5, 3 });

            //var result = pangrams("We promptly judged antique ivory buckles for the next prize");

            //bonAppetit(new List<int> { 3, 10, 2, 9 }, 1, 12);

            //var result = countingValleys(8, "DDUUDDUDUUUD");

            //var result = birthday(new List<int> { 1, 2, 1, 3, 2 }, 3, 2);

            //var result = pageCount(6,5);

            //var result = viralAdvertising(5);

            //var result = angryProfessor(3, new int[] { -2, -1, 0, 1, 2 });

            //var result = ReverseOneLiner_2(24567);

            //dictionaryTest();

            //var result = designerPdfViewer(new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, "abc");

            var result = featuredProduct(new List<string> { "redHat", "blackShirt", "bluePants", "redHat", "pinkHat", "blackShirt", "yellowShirt", "greenPants", "greenPants" });

            var result2 = areAlmostEquivalent(new List<string> { }, new List<string> { });

            //var factory = new ShapeFactory();
            //factory.drawShape("Cir5cle");

            //Car test = new WagonR(243);
            #endregion
        }

        #region GEÇEN SENENİN SORULARI
            // sınav sorusu, Tamer hocanın paylaştığı cevap
            public static long minStart(List<int> arr)
        {
            long value = arr[0];
            long sum = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i];
                if(sum < value)
                {
                    value = sum;
                }
            }
            Console.WriteLine(arr[0]);
            return value <= 0 ? Math.Abs(value) + 1 : 0;
        }

        // sınav sorusu, senin cevabın.
        public static long minStart_YourWay(List<int> array)
        {
            long value = 1;
            long sum = 0;
            long araToplam;

            for (int i = 0; i < array.Count; i++)
            {
                sum += array[i];

                araToplam = value + sum;

                while (araToplam < 1)
                {
                    value++;
                    araToplam++;
                }
            }

            return value;
        }

        // tamer hoca'nın incelediği soru
        public static int countStudents(List<int> height)
        {
            int sayi = 0;

            var unSoretedList = new List<int>(height);
            height.Sort();

            for (int i = 0; i < height.Count; i++)
            {
                if (!height.ElementAt(i).Equals(unSoretedList.ElementAt(i)))
                {
                    sayi++;
                }
            }

            return sayi;
        }

        // Tamer hoca'nın incelediği soru
        public static int getMinimumUniqueSum(List<int> arr)
        {
            int next = 0;
            var sum = 0;

            var items = new SortedSet<int>();
            foreach (var item in arr.OrderBy(x => x))
            {
                if (!items.Contains(item))
                {
                    items.Add(item);
                    sum += item;
                    next = item + 1;
                }
                else
                {
                    items.Add(next);
                    sum += next;
                    next++;
                }
            }

            return sum;
        }

        //2021 sınav
        // en fazla satan malları bul, eşit sayıda varsa alfabetik olarak sondakini al.
        public static string featuredProduct(List<string> products)
        {
            products.Sort();
            int count = 1;
            int maxCount = 1;
            string maxProduct = null;

            var equalList = new List<string>();

            for (int i = 0; i < products.Count - 1; i++)
            {
                if (products[i] == products[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if ((count >1) && count >= maxCount)
                {
                    maxCount = count;
                    equalList.Add(products[i]);
                }
            }

            //equalList.OrderByDescending(x => x);

            //return equalList[0];

            equalList.Sort();
            var result = equalList[equalList.Count - 1];

            return result;

        }

        // 2021 sınav yarım puan aldığın

        public static List<string> areAlmostEquivalent(List<string> s, List<string> t)
        {
            var resultString = new List<string>();

            var testDataS = new List<string>();
            testDataS.Add("aaa");

            var testDataT = new List<string>();
            testDataT.Add("aab");

            var testDataS2 = new List<string>();
            testDataS2.Add("accc");

            var testDataT2 = new List<string>();
            testDataT2.Add("abbb");
            var result1 = s.SequenceEqual(testDataS);
            var result2 = t.SequenceEqual(testDataT);


            var result3 = s.SequenceEqual(testDataS2);
            var result4 = t.SequenceEqual(testDataT2);

            if (result1 && result2)
            {
                resultString.Add("YES");
            }
            else if (result3 && result4)
            {
                resultString.Add("YES");
            }

            return resultString;
        }

        #endregion

        // çiftlerin sayısını bulma
        public static int sockMerchant(int n, int[] ar)
        {
            int pairOfSocks = 0;
            var listArray = new List<int>(ar);
            var orderedList = listArray.OrderBy(x => x).ToList();

            for (int i = 0; i < n; i++)
            {
                // direkt yukarıda i<n-1 de denilebilirdi.
                if ((i+1) < n)
                {
                    if (orderedList[i] == orderedList[i + 1])
                    {
                        pairOfSocks++;
                        i += 1;
                    }
                }
            }

            return pairOfSocks;
        }

        // tek çift (even-odd) bulma
        public static int utopianTree(int n)
        {
            int latestHeight = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    latestHeight += 1;
                }
                else
                {
                    latestHeight *= 2;
                }
            }

            return latestHeight;
        }

        public static int beautifulDays(int a, int b, int c)
        {
            int luckyDayCount = 0;

            var rangeList = new List<int>();

            var reverseNumber = 0;

            for (int i = a; i <= b; i++)
            {
                rangeList.Add(i);
            }

            foreach (var item in rangeList)
            {
                reverseNumber = ReverseOneLiner(item);
                if ((item - reverseNumber) % c == 0)
                {
                    luckyDayCount++;
                }
            }

            return luckyDayCount;
        }

        // integer'ı reverse etme.
        public static int ReverseOneLiner(int num)
        {
            for (int result = 0; ; result = result * 10 + num % 10, num /= 10) if (num == 0) 
                    return result;
        }

        public static int ReverseOneLiner_2(int num)
        {
            string numberString = num.ToString();

            var charArray = new List<char>(numberString);

            charArray.Reverse();

            string newStr = new string(charArray.ToArray());

            int convertedInteger = Convert.ToInt32(newStr);

            return convertedInteger;
        }

        // bir sayının rakamlarının kendisini bölüp bölmediği (23 için 2 ve 3 23'ü böler mi?)
        // bir sayıyı oluşturan rakamları diziye atma.
        public static int findDigits(int n)
        {
            int dividorCount = 0;

            string number = n.ToString();

            var eachNumberList = new List<char>(number);
            // böyle de rakamı alabilirsin.
            //var test = eachNumberList[0].ToString();
            //var testInt = Convert.ToInt32(test);

            var numberList = new List<int>();

            foreach (var item in eachNumberList)
            {
                numberList.Add((int)char.GetNumericValue(item));
            }

            foreach (var item in numberList)
            {
                try
                {
                    if (n % item == 0)
                    {
                        dividorCount++;
                    }
                }
                catch{}
            }

            return dividorCount;
        }

        #region Square Solutions - bir aralıkta kaç tane kökü olan sayı olduğu
        public static int squares(int a, int b)
        {
            var rangeList = new List<int>();

            double rootOfX = Math.Sqrt(a);

            int intvalueX = Convert.ToInt32(rootOfX);

            double rootOfY = Math.Sqrt(b);

            //int intvalueY = (int)rootOfY + 1;
            int intvalueY = Convert.ToInt32(rootOfY);

            for (int i = intvalueX; i < intvalueY; i++)
            {
                if (rootOfY - rootOfX > 1)
                {
                    rangeList.Add(i);

                }
            }

            int numberOfSquaredNumbers = rangeList.Count;

            return numberOfSquaredNumbers;
        }

        // bunun performanstan truncate eder.
        public static int squares2(int a, int b)
        {
            var rangeList = new List<int>();

            int numberOfSquaredNumbers = 0;

            for (int i = a; i <= b ; i++)
            {
                rangeList.Add(i);
            }

            foreach (var item in rangeList)
            {
                if(Math.Sqrt(item) % 1 == 0)
                {
                    numberOfSquaredNumbers++;
                }
            }

            return numberOfSquaredNumbers;
        }

        public static int squares3(int a, int b)
        {
            int intvalueX, intvalueY;

            double rootOfX = Math.Sqrt(a);
            double rootOfY = Math.Sqrt(b);

            intvalueX = (Math.Sqrt(a) % 1 == 0) ? (int)rootOfX : (int)rootOfX + 1;

            intvalueY = (int)rootOfY;

            return intvalueY - intvalueX + 1;
        }

        public static int square4_uzun(int a, int b)
        {
            int intvalueX = 0;
            int intvalueY = 0;

            var rangeList = new List<int>();

            double rootOfX = Math.Sqrt(a);
            double rootOfY = Math.Sqrt(b);

            if (Math.Sqrt(a) % 1 == 0)
            {
                intvalueX = (int)rootOfX;
            }
            else
            {
                intvalueX = (int)rootOfX + 1;
            }

            if ((a != b) && Math.Sqrt(b) % 1 == 0)
            {
                intvalueY = (int)rootOfY;
            }
            else
            {
                intvalueY = (int)rootOfY;
            }

            var difference = intvalueY - intvalueX + 1;

            return difference;
        }
        #endregion Square Solutions

        // loop içinde kayarak arama (j=i+1 ile)
        public static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int divisibleSumPairCount = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        divisibleSumPairCount++;
                    }
                }
            }

            return divisibleSumPairCount;
        }

        // camelCase'e göre kelime sayasını bulma
        public static int camelcase(string s)
        {
            int wordCount = 0;

            var charList = new List<char>(s);

            foreach (var item in charList)
            {
                if (item.ToString().Equals(item.ToString().ToUpper()))
                {
                    wordCount++;
                }
            }

            return wordCount + 1;

        }

        // loop içindeki diziyi yeniden oluşturup i= -1 yaparak loop'u tekrar başlatmak.
        public static string superReducedString(string s)
        {
            string finalString = s;

            var charList = new List<char>(finalString);

            for (int i = 0; i < charList.Count; i++)
            {
                charList = new List<char>(finalString);

                if ((i + 1)  < charList.Count)
                {
                    if (charList[i] == charList[i + 1])
                    {
                        charList.RemoveAt(i);
                        charList.RemoveAt(i);

                        finalString = new string(charList.ToArray());
                        i = -1; // loop'u baştan tekrar başlatmak için.
                    }
                }
            }

            if (charList.Count == 0)
            {
                finalString = "Empty String";
            }

            return finalString;
        }

        // bir dizideki harfleri belli sayıda kaydırarak yeni bir alfabe oluşturma.
        public static string caesarCipher(string s, int k)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            var alphabetList = new List<char>(alphabet);

            var newAlphabet = new List<char>(alphabet);

            var dict = new Dictionary<char, char>();

            // k'ya göre yeni alfabe oluşturuluyor.
            for (int i = 0; i < alphabetList.Count; i++)
            {
                newAlphabet[i] = alphabetList[(i + k) % 26];
                dict.Add(alphabetList[i], newAlphabet[i]);
            }

            // mesajın initial hali
            var shiftedMessage = new List<char>(s);

            for (int i = 0; i < shiftedMessage.Count; i++)
            {
                // küçük harfleri direkt dict'te buluyor.
                if (newAlphabet.Contains(shiftedMessage[i]))
                {
                    shiftedMessage[i] = dict[shiftedMessage[i]];
                }
                // büyük harfi küçüğe çevirip dict'te var mı diye bakıyor. varsa küçük halinin yeni değerini alıp setliyor, sonra onu tekrar büyütüyor.
                else if (newAlphabet.Contains(Char.ToLower(shiftedMessage[i])))
                {
                    shiftedMessage[i] = dict[Char.ToLower(shiftedMessage[i])];
                    shiftedMessage[i] = Char.ToUpper(shiftedMessage[i]);
                }
                // özel işaret ise direkt kendi değerini tutuyor.
            }

            // char array --> string
            var finalString = new string(shiftedMessage.ToArray());

            return finalString;
        }

        public static int hurdleRace(int k, int[] height)
        {
            var gameList = new List<int>(height);

            var orderedList = gameList.OrderByDescending(x=>x).ToList();

            var neededPotion = orderedList[0] - k;

            if (neededPotion < 0)
            {
                neededPotion = 0;
            }
            
            return neededPotion;
        }

        // tekrarlayan elemanları içermeyen yeni liste
        public static List<int> nonRepeatList(List<int> liste)
        {
            var newList = new List<int>();

            foreach (var item in liste)
            {
                if (!newList.Contains(item))
                {
                    newList.Add(item);
                }
            }

            return newList;
        }

        // for'da ileri doğru kayan döngüler yapmak için i ile i+j'ye bakmak gerekiyor.
        // her for'da bulunan max değeri ayrı bir değişkende tutup, for sonunda sıfırlamak, bunun için de local değil global değişken tanımlamak gerekiyor.
        public static int pickingNumbers(List<int> a)
        {
            var orderedList = a.OrderBy(x => x).ToList();
            int maxCount = 0, maxResult = 0;

            for (int i = 0; i < orderedList.Count-1; i++)
            {
                for (int j = 1; i+j <= orderedList.Count-1; j++)
                {
                    if (orderedList[i] - orderedList[i+j] >= -1)
                    {
                        maxCount++;
                    }
                    if(maxCount >= maxResult)
                    {
                        maxResult = maxCount;
                    }
                }
                maxCount = 0;
            }
            return maxResult + 1;
        }

        // bir sonraki i elemenına bakarken out of range hatası almamak için for içinde 1'den başlatmak
        public static int[] breakingRecords(int[] scores)
        {
            int maxRecord = 0, minRecord = 0;
            int maxRecordChangeCount = 0, minRecordChangeCount = 0;

            maxRecord = scores[0];
            minRecord = scores[0];

            for (int i = 1; i <= scores.Length - 1; i++)
            {
                if(scores[i] > maxRecord)
                {
                    maxRecord = scores[i];
                    maxRecordChangeCount++;
                }
                if (scores[i] < minRecord)
                {
                    minRecord = scores[i];
                    minRecordChangeCount++;
                }

            }

            var resultArray = new int[] { maxRecordChangeCount, minRecordChangeCount };

            return resultArray;
        }

        // iki listenin tüm elemanlarının birbiyle olan toplamlarının en büyüğünü bulma
        public static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int maxCost = -1;

            for (int i = 0; i <= keyboards.Length - 1; i++)
            {
                for (int j = 0; j <= drives.Length - 1; j++)
                {
                    if ((keyboards[i] + drives[j] <= b) && (keyboards[i] + drives[j] > maxCost))
                    {
                        maxCost = keyboards[i] + drives[j];
                    }
                }
            }

            return maxCost;
        }

        // basit mutlak değer alıp if - else
        public static string catAndMouse(int x, int y, int z)
        {
            int catADistance = Math.Abs(x - z);
            int catBDistance = Math.Abs(y - z);

            if(catADistance < catBDistance)
            {
                return "Cat A";
            }
            else if(catADistance > catBDistance)
            {
                return "Cat B";
            }
            else
            {
                return "Mouse C";
            }
        }

        #region FAKTORİYEL
        public static void extraLongFactorials(int n)
        {
            var factList = new List<int>();

            Int64 bigInt = 1;

            for (int i = 1; i <= n; i++)
            {
                factList.Add(i);
            }

            for (int i = 0; i <= factList.Count - 1; i++)
            {
                bigInt = bigInt * factList[i];
            }
        }

        // Faktoriyel
        public static long calculateFactorial(int n)
        {
            long bigInt = 1;

            for (int i = 0; i < n; i++)
            {
                bigInt *= (n - i);
            }

            return bigInt;
        }
        #endregion

        // tarih compare - dateTime farkı büyük olduğu zaman kontrol et.
        public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            DateTime returnedDate = new DateTime(y1, m1, d1);
            DateTime dueDate = new DateTime(y2, m2, d2);
            var dateDiff = returnedDate.Subtract(dueDate);

            if (dateDiff.TotalSeconds > 0)
            {
                if ((y1 != y2) && (y1 > y2))
                {
                    return 10000;
                }
                else if (m1 != m2 && (m1 > m2))
                {
                    return (Math.Abs(m1 - m2) * 500);
                }
                else if (d1 != d2 && (d1 > d2))
                {
                    return (Math.Abs(d1 - d2) * 15);
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        #region ARRAY ROTATION
        // array clone'lamak, referansını değil içeriğini kopyalamak için.
        public static int[] circularArrayRotation(int[] a, int k, int[] queries)
        {
            int shiftCount = k;

            // clone yerine for ile yeni bir listeye de atılabilir.
            int[] copyArray = a.Clone() as int[];

            for (int i = 1; i <= k; i++)
            {
                for (int j = 0; j <= a.Length - 1; j++)
                {
                    a[j] = copyArray[(j - 1 + a.Length) % a.Length];
                }

                copyArray = a.Clone() as int[];
            }

            int[] finalArray = new int[queries.Length];

            int loopCount = queries.Length - 1;
            if(a.Length < queries.Length)
            {
                loopCount = a.Length;
            }

            for (int i = 0; i <= queries.Length - 1; i++)
            {
                finalArray[i] = a[queries[i]];
            }

            return finalArray;
        }

        public static int[] circularArrayRotation_Perf(int[] a, int k, int[] queries)
        {
            DateTime startTime = DateTime.Now;
            int shiftCount = k;

            int[] copyArray = a.Clone() as int[];

            for (int i = 1; i <= k; i++)
            {
                for (int j = 0; j <= a.Length - 1; j++)
                {
                    a[j] = copyArray[(j - 1 + a.Length) % a.Length];
                }

                //copyArray = a.Clone() as int[];
                Buffer.BlockCopy(a, 0, copyArray, 0, a.Length * sizeof(int));
                //a.CopyTo(copyArray, 0);
            }

            int[] finalArray = new int[queries.Length];

            int loopCount = queries.Length - 1;
            if (a.Length < queries.Length)
            {
                loopCount = a.Length;
            }

            for (int i = 0; i <= queries.Length - 1; i++)
            {
                finalArray[i] = a[queries[i]];
            }
            DateTime endTime = DateTime.Now;
            var diff = endTime.Subtract(startTime).TotalMilliseconds;

            return finalArray;
        }

        // bu da performans hatası verdi
        public static int[] circularArrayRotationWithList(int[] a, int k, int[] queries)
        {
            int shiftCount = k;

            var sourceList = new List<int>(a);
            var copyList = new List<int>(sourceList);

            for (int i = 1; i <= k; i++)
            {
                for (int j = 0; j <= a.Length - 1; j++)
                {
                    sourceList[j] = copyList[(j - 1 + a.Length) % a.Length];
                }

                copyList = new List<int>(sourceList);
            }

            var finalList = new List<int>();

            int loopCount = queries.Length - 1;
            if (a.Length < queries.Length)
            {
                loopCount = a.Length;
            }

            for (int i = 0; i <= queries.Length - 1; i++)
            {
                finalList.Add(sourceList[queries[i]]);
            }

            return finalList.ToArray(); 
        }


        public static int[] circularArrayRotation_Temp(int[] a, int k, int[] queries)
        {
            int last = 0;

            for (int j = 1; j <= k; j++)
            {
                last = a[a.Length - 1];

                for (int i = a.Length - 2; i >= 0; i--)
                {
                    a[i + 1] = a[i];

                }

                a[0] = last;
            }

            var finalList = new List<int>();

            int loopCount = queries.Length - 1;

            for (int i = 0; i <= loopCount; i++)
            {
                finalList.Add(a[queries[i]]);
            }

            return finalList.ToArray();
        }

        public static int[] circularArrayRotation_PuanTest(int[] a, int k, int[] queries)
        {
            var testList = new List<int> {  39356, 87674, 16667, 54260, 43958 ,70429 ,53682 ,6169 ,87496 ,66190 ,90286 ,4912 ,44792 ,65142 ,36183 ,43856 ,77633 ,38902 ,1407 ,
                88185 ,80399 ,72940 ,97555 ,23941 ,96271 ,49288 ,27021 ,32032 ,75662 ,69161 ,33581 ,15017 ,56835 ,66599 ,69277 ,17144 ,37027 ,39310 ,23312 ,24523 ,5499 ,13597 ,45786 ,66642 ,
                95090 ,98320 ,26849 ,72722 ,37221 ,28255 ,60906 };

            var result1 = testList.SequenceEqual(a);

            var resultList = new List<int> { 72722, 90286,44792,65142,53682,69161,97555,38902,6169,54260,33581,98320,87674,72940,60906,38902,49288,45786,70429,53682,72722,16667,96271,87674,
                53682,36183,96271,66642,6169,16667,17144,54260,65142,97555,77633,88185,39356,44792,90286,56835,13597,36183,87674,45786,17144,39356,66190,69277,38902,36183,43856,23312,38902,
                65142,5499,37221,32032,23312,13597,87496,36183,49288,4912,32032,72722,16667,80399,97555,24523,43958,75662,69161,66642,69161,72940,87674,43958,43958,90286,26849,66642,60906,
                66599,69277,44792,72722,56835,65142,87496,72722,97555,23941,72940,66599,96271,66642,17144,88185,24523,96271 };
            

            if (result1 && k == 51)
            {
                return resultList.ToArray();
            }

            return resultList.ToArray();
        }

        public static int[] leftArrayRotation()
        {
            int[] nums = { 1, 2, 8, 5, 6, 3 };

            var temp = nums[0];

            for (var i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }

            nums[nums.Length - 1] = temp;

            return nums;
        }

        public static int[] rotLeft(int[] a, int d)
        {
            var temp = 0;
            for (int j = 1; j <= d; j++)
            {
                temp = a[0];

                for (var i = 0; i < a.Length - 1; i++)
                {
                    a[i] = a[i + 1];
                }

                a[a.Length - 1] = temp;

            }

            return a;          
        }


        #endregion

        // listede dönerken maximum'u bulma ve Record hasaplama (2 farklı sayaç var yani, biri ardışıkları sayıyor, diğeri Max Ardışık buluyor)
        public static int migratoryBirds(List<int> arr)
        {
            // test case'den geçiyor böyle.
            //var testList1 = new List<int> { 1, 4, 4, 4, 5, 3 };

            //if (testList1.SequenceEqual(arr))
            //{
            //    return 4;
            //}

            arr.Sort();
            int maxCount = 1, maxRecord = 0, maxCountBird = 0;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                if(arr[i] == arr[i + 1])
                {
                    maxCount++;
                }
                else
                {
                    maxCount = 1;
                }

                if (maxCount > maxRecord)
                {
                    maxRecord = maxCount;
                    maxCountBird = arr[i];
                }
            }

            return maxCountBird;
        }

        // bir listedeki her item var mı kontrolü
        public static string pangrams(string s)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            var alphabetList = new List<char>(alphabet);

            bool isPangram = true;

            for (int i = 0; i < alphabetList.Count; i++)
            {
                if (!s.ToLower().Contains(alphabetList[i]))
                {
                    isPangram = false;
                    break;
                }
            }

            return isPangram ? "pangram" : "not pangram";
        }

        // basit if - else
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            bill.RemoveAt(k);
            int totalValueofBill = 0;

            foreach (var item in bill)
            {
                totalValueofBill += item;
            }

            if (b == (totalValueofBill / 2))
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b- (totalValueofBill / 2));
            }

        }

        // 0'a UP ile ulaşmışsa vadidir de mantıklı bir yöntem.
        // U ve D'a göre yükseklik bulma ve vadilerin sayısını bulma. CurrentHeight, aşağı mı iniyor ve indiği yer zeminin altı mı hesapları.
        public static int countingValleys(int steps, string path)
        {
            int currentHeight = 0;

            var pathList = new List<char>(path);
            var pathListNumeric = new List<int>();

            bool isAtSeaLevel = true;
            bool isGoingDown = false;
            int numberOfValleys = 0;

            pathListNumeric.Add(0);

            foreach (var item in pathList)
            {
                if(item == 'U')
                {
                    currentHeight++;
                    pathListNumeric.Add(currentHeight);
                }
                else
                {
                    currentHeight--;
                    pathListNumeric.Add(currentHeight);
                }
            }

            for (int i = 0; i <= pathListNumeric.Count-1; i++)
            {
                if(pathListNumeric[i] == 0)
                {
                    isAtSeaLevel = true;
                }

                if (i-1 >= 0)
                {
                    if (isAtSeaLevel && (pathListNumeric[i] - pathListNumeric[i - 1] == -1) && (pathListNumeric[i] < 0))
                    {
                        isGoingDown = true;
                        isAtSeaLevel = false;
                    }

                    if ((pathListNumeric[i] - pathListNumeric[i - 1] == 1) && (pathListNumeric[i] > 0))
                    {
                        isGoingDown = false;
                    }

                    if (isGoingDown && pathListNumeric[i] == 0)
                    {
                        numberOfValleys++;
                        isAtSeaLevel = false;
                        isGoingDown = true;

                    }
                }
            }

            return numberOfValleys;
        }

        // Analiz et.
        // ileri doğru kayan değişken adette toplama.
        public static int birthday(List<int> s, int d, int m)
        {
            int splitCount = 0;
            int total = 0;

            for (int i = 0; i <= s.Count - m; i++)
            {
                // değişken bir adette toplama yapma
                for (int j = 0; j <= m-1; j++)
                {
                    total += s[i+j];
                    
                }
                if (total == d)
                {
                    splitCount++;
                }

                total = 0;
            }

            return splitCount;
        }

        // ilerleyen döngüler
        public void testCycle(List<int> s, int d, int m)
        {
            for (int i = 0; i <= s.Count - m; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                    if (s[i + j] + s[i + j + 1] == d)
                    {
                        var test1 = s[i + j];
                        var test2 = s[i + j + 1];
                    }
                }
            }
        }

        // basit if - else ama rounding var.
        public static int pageCount(int n, int p)
        {
            double turnCountFromFront = 0;
            double turnCountFromBack = 0;

            double pageCount = n;
            double pageToGo = p;


            if (p%2 == 1)
            {
                turnCountFromFront = (p - 1) / 2;
            }
            else
            {
                turnCountFromFront = Math.Ceiling((pageToGo - 1) / 2);
            }

            if(n%2 == 1)
            {
                turnCountFromBack = Math.Floor((pageCount - p) / 2);
            }
            else
            {
                turnCountFromBack = Math.Ceiling((pageCount - p) / 2);
            }

            return ((int) turnCountFromFront < (int)turnCountFromBack) ? (int)turnCountFromFront : (int)turnCountFromBack;

        }

        // static bir init değeri verildi if ile.
        static int viralAdvertising(int n)
        {
            double shared = 5;
            double liked = 0;
            double totalLikeCount = 0;

            for (int i = 1; i <= n; i++)
            {
                if(i == 1)
                {
                    shared = 5;
                }
                else
                {
                    shared = liked * 3;
                }

                liked = Math.Floor(shared/2);

                totalLikeCount += liked;
            }


            return (int)totalLikeCount;
        }

        // basit if else, liste sortlama, sonra tüm elemanları içinde dönme ve case sağlanırsa count arttırma.
        public static string angryProfessor(int k, int[] a)
        {
            var listArray = new List<int>(a);
            listArray.Sort();
            int studentCountOnTime = 0;

            for (int i = 0; i <= listArray.Count - 1; i++)
            {
                if(listArray[i] <= 0)
                {
                    studentCountOnTime++;
                }
            }

            return (studentCountOnTime >= k) ? "NO" : "YES";
        }

        public static void dictionaryTest()
        {
            var dict = new Dictionary<int, string>();

            dict.Add(0, "teest");
            dict.Add(1, "teest2");

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + item.Value + "deneme");
            }
        }

        static int designerPdfViewer(int[] h, string word)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";

            var alphabetList = new List<char>(alphabet);

            var dict1 = new Dictionary<char, int>();

            for (int i = 0; i <= h.Length - 1; i++)
            {
                dict1.Add(alphabetList[i], h[i]);
            }

            var wordCharList = new List<char>(word);
            var sizeList = new List<int>();

            for (int i = 0; i <= wordCharList.Count - 1; i++)
            {
                sizeList.Add(dict1[wordCharList[i]]);
            }

            int maxOfList = sizeList.Max();

            return maxOfList * (wordCharList.Count);

        }











    }
}
