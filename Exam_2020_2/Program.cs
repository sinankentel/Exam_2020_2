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

            var testListEqual = new List<int> { -5, 4, -2, 3, 1, -1, -6, -1, 0, 5 };

            int[] testArray3 = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            // capacity verebilirsin list ve array'e. veya direkt array'i list'e kopyalayabilirsin.
            int[] testArray4 = new int[5];
            var testList3 = new List<int>(testArray3);
            var testList4 = new List<int>(5);
            #endregion

            #region LIST EŞİTLİK CHECK
            bool isSameList = testList.SequenceEqual(testListEqual);
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

            //var result = circularArrayRotation_Perf(new int[] { 39356, 87674, 16667, 54260, 43958 ,70429 ,53682 ,6169 ,87496 ,66190 ,90286 ,4912 ,44792 ,65142 ,36183 ,43856 ,77633 ,38902 ,1407 ,
            //    88185 ,80399 ,72940 ,97555 ,23941 ,96271 ,49288 ,27021 ,32032 ,75662 ,69161 ,33581 ,15017 ,56835 ,66599 ,69277 ,17144 ,37027 ,39310 ,23312 ,24523 ,5499 ,13597 ,45786 ,66642 ,
            //    95090 ,98320 ,26849 ,72722 ,37221 ,28255 ,60906}, 6000, new int[] { 47, 10, 12, 13 });

            //var result = circularArrayRotation_Perf(new int[] { 1,2,3}, 2, new int[] { 0,1,2});

            //var result = migratoryBirds(new List<int> { 1, 2, 3, 3, 3, 3, 4, 4, 4 });

            var result = pangrams("We promptly judged antique ivory buckles for the next prize");


            #endregion
        }

        #region GEÇEN SENENİN MIN_START SORUSU
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
        #endregion

        // çiftlerin sayısını bulma
        public static int sockMerchant(int n, int[] ar)
        {
            int pairOfSocks = 0;
            var listArray = new List<int>(ar);
            var orderedList = listArray.OrderBy(x => x).ToList();

            for (int i = 0; i < n; i++)
            {
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
                    latestHeight = latestHeight * 2;
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

        // bir sayının rakamlarının kendisini bölüp bölmediği (23 için 2 ve 3 23'ü böler mi?)
        // bir sayıyı oluşturan rakamları diziye atma.
        public static int findDigits(int n)
        {
            int dividorCount = 0;

            string number = n.ToString();

            var eachNumberList = new List<char>(number);

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
                bigInt = bigInt * (n - i);
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
        #endregion

        // listede dönerken maximum'u bulma ve Record hasaplama (2 farklı sayaç var yani, biri ardışıkları sayıyor, diğeri Max Ardışık buluyor)
        public static int migratoryBirds(List<int> arr)
        {
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


    }
}
