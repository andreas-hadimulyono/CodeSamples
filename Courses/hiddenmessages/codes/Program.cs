using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codechallenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            //var k = 5;
            //var d = 2;
            //var dna = new[] {
            //    "TGTTGTTCCTATGGCTTTGCAGGAC",
            //    "AGCAACTAGTACGCCTGGTGTTTGG",
            //    "TACCGGTATGTTACCTTTGCATCGT",
            //    "CTTGGAGGTCAGTCGGACCATCGAA",
            //    "GACAGCTTGCCCTGTTATGTGAACA",
            //    "TAATAGGTCTAATCTCTTGGGACTA"
            //};

            //var motifEnumeration = p.MotifEnumeration(dna, k, d);
            //var textoutput = string.Join(" ", motifEnumeration.ToArray());

            //var pattern = "CACCAG";
            //var dna = new[] {
            //    "GACGTGATCTTCTTTAATAACGAGCAGAATCCCGCTTGGCGGTCGTCCCACTAGGGTGGTAAAAACCGAAGCGCATGCAAGAGTCCTTAGGACAT",
            //    "CTTAACCTCTCTTGTCTTCTACATAGATTAAGACAAAAGCAAATGAGCCCGCCCAAAAGGTGGTTGCCATGTGCATCCCAATCGTCTTACTCACG",
            //    "ACGTGAAGAACGGTTTAATATTAAGTCTACAACAACGGCGTACGCGAACCGCCTTAGACAGTGGAGACGATTGCCAACCCAACAGACGAGAAACA",
            //    "TACTACGGCTGCCGTAGACCAGGTAACCGCACTCGGGCCAGTGGATGCAAGCTTCAACAATGTGGATATCTGAGGCGCGCAAATACCGGGCATCG",
            //    "CCTTCACAACAGATTCGGGGTCTTATATACCTCTACCCACAGCCGCGAGACAAATGGAACTAACCGTCAAAGTAGCACGCTCGCCGTGCAACACA",
            //    "ACCCAGAACCGGGACATTCAATAATTACTTCGCCTTCAATTGTAATATCGCTATACCCTTACCTCACCAGAACTTGTATACTGTTATATGTCGGC",
            //    "ACAAGCTGGTTACCTCATGCTATCGCTTCTTGACGATATTAATGCTTACTACTCACGACCGTATTGGTAAGAAACTCGCCAACGACCTTCGGGAA",
            //    "AATAACCCGCAATTGATACCGTCCTTAATACTGGATCGACTGGAATAGCCATCGATACGGTCGTTGTCGAGAAAACTTCAACTCCGGATGTTTGC",
            //    "TGTGGGTCATACTGTTTAGACCAAGTAGATTTACGGTAGCCTGGTACGGCTTCTAGTTCAAAGAGGGGATCGTGTTCAACGAGTGCAGGACGGGA",
            //    "ACAATGCTTTGTGATAAGTACCGAGGGGGCGAATAATACTTGCTAGGGGGGACGAAGGTTCATACCATAGGTTTCACGGGGCCTTGCGAGTCAAG",
            //    "CTAGGCTAAAAAAAGTGAAAACAGTTCGCGAAGAATAACTCTGCAAGGACTATTGAAATCCCGTTCCCGCCATCATCACCCAGGAAACACATGTT",
            //    "CCAGTGTCGCGAAAGACTCTAAGTTGTTGGTACTAAGTAGCGAAGCGACGCGCGGTCGCTTTTAAGCGGGTTAGGCCATTTGGACAGACTCAGTT",
            //    "TGCTTCGTAGCTCATAGGTTCTGGTTAGAGTACTGGAATCTGAGGGCCAGAATATATTCCGTACACAGGCATAGTGGCAGTGCCAGGTTTATCAG",
            //    "CAACTCACAGTCAAGGCCTCATCAACCGGATCTGCTAATTTTGGAAAGACAGACTATCGCACCCGGGGGGTCTTGTGATGGGTCTCGCTATGATC",
            //    "GGATCCCTTGTAGCCCAGCATAGAGAGCCTACAGTAGGTGACTTCGTTTTTCTACGGGGGGAAATTAGCAATTGCATATAATCACTAGAGTGTCT",
            //    "TGAGGCTCGTTAGTGCGCACGACCGTTCACACCACCGTTAGTACTATGGAAATAGGGTGTGGACATTTTATCGTAAGTGATGCTCTAAACACCAC",
            //    "TATCGTTCATATTTAACTTGATTGTCTACCTGGGTGGACTTTCTGTTAGTCATTGAGGCTTATCGCCGAATACTAGCTGTGCATCTATGCTCAAT",
            //    "CAGCGAGCTGACCTGGCCTATAGCACACCGGTTCCCAAACCCGCTGGTGGTCTACAAATCGGAATCCGCCGCGATAGTATAAGAGTAAATCGCCA",
            //    "ACAGGTCGTTACAGCATGAAGACTGTTCGGCAGCCAACAAACGAAAGAAATGTGTCCCTTGGGGGTGTGTTGTTGGATGTGATAGAGGTAAACTA",
            //    "AGGACGCGGTTTCCATAAATTTTGGTTTTAATTAGGCCTAAGCTCTGGCCTTCCAGCTATTGTCCCTGAGAGTCGTTAGAGGGGCTAAGTAGATA",
            //    "CTGCGCCCGCTAGCGTGAGTCCCGACGTCGCTGCCCACGCAATTTGACGATTCCCCCTGGCGGCGAGCAGGAATGTATGTCGATTCTTTCTGCCG",
            //    "TTAGTGATAAGCAAAATGGGCTATGTCTTGAATATAACTGTACATGGAGCTGGTAGTGTTAAAGGCGTAGTTTTGTGTCCTTTGTATGCGGTGAC",
            //    "ACGTAGAATTGAGGAACGGCCTTAACAGCTTTTTGGGTGCCGTTCCTACTCCTACGACCGGCGGCCTTCGCATCCCTCAATTAATGTAATCAGAT",
            //    "AAAAACAGAGGCAGTAAGTAGCTATCTCGATAGGCTGTAGAAGCTTATTTACTGAAACACAACTTGCAGTACTTGAGCAGTTGCGTCCACGTAGA",
            //    "TACAGTCAATCTTGTTGCGTCCCCACATCGTAAGGTAGCACTCGAGACTAACCGACTGCCTCACAGGGTGAGACAACCAAAATGGAGACAGCGTG",
            //    "ACAGTACCGGCGCCAGAATATTATCGTGTTATGGTAATTCCGAGATAATATTCTCTCGCTGGTGGCTCTCGCACGCCCGCTTAGTAAGAACCTCT",
            //    "CGAGTTCAAATCCAGAACTTTATGGCCGTGAAGGAGGCATGGTGGAATCAACGTTAGCAGCAGTCGTACTCACTTAGCTCTTACGTTAATCCCTT",
            //    "GTATCAGCGGGGTGGGTGCAGCGGGAGATCATGCTCTTTCCCATAACCCTACAAGAACCCGAAAATAACTAAGGGGATGACAACTACAAAGTGTT",
            //    "AGAGGCTCAGGTGTGAGATCCTGTGATGGTAATCAACGTAGGCTGCATTCAGGTTATTGCCCTAAACGAACTGACTATGTCACTCTAATACTACT",
            //    "GCCGCCGATGCACCGGGCATGCACTGTGCTCCGTTCGGAAGTGGGTGGGCTCTACCTGACGCTTGATTAAATCGGGTGAATAGTGTGATCGTTTT",
            //    "ACAATAATCGATCAGACGGACTTACAGCATTTTACACACGGCAGGCAATGCTCAACGTACGCGTCTTCACTACAACGAGACACTCGCGAGCCCCA"
            //};
            //var d = p.DistanceBetweenPatternAndString(pattern, dna);

            //var k = 6;
            //var dna = new[] {
            //    "GCATGCAGACCAAGCGCTAAGCTAAGAAATATAACAACGGGC",
            //    "ACGGGCTGGGTGACGCCATCAGTTATTACCTCCACTTAAGCG",
            //    "AGTTATACCATCACGGGCTTGCCTCTAGGGGCCATAAATTGA",
            //    "GGCTTTACGGGCAGGCTGTCGGCATAGTTGTAGACAGAGACC",
            //    "CGGCATACTGGCATTTACTCCTGGTATACGAGTTTTTGTGCC",
            //    "GCGGAGGTTGTTACCGGCCATCGGCGGCTCGCTGGCCTTGTT",
            //    "CGACATGGACGGCGCTGCGTTCTGGTAATTACTGGCTTTATT",
            //    "TAAGTTTTCCAGGGGACCACTCCAACTTTGACAGGCTAGATA",
            //    "GTATGGAACGCCACGGGCGGGGATTGCAGGGTCCGGGGGTCG",
            //    "CACTCCCTTAATATTGCGAGGAGGGATGCCACTGGCATCGGG"
            //};
            //var m = p.MedianString(dna, k);

            //var inputfile = "mp5.txt";
            //var output = p.MostProbableKmer(inputfile);

            //var inputFile = "gms6.txt";
            //var output = p.GreedyMotifSearch(inputFile);
            //var textOutput = string.Join(" ", output.ToArray());

            //var inputFile = "gp6.txt";
            //var output = p.GreedyMotifSearchWithPseudocounts(inputFile);
            //var textoutput = string.Join(" ", output.ToArray());

            //var k = 7;
            //var dna = new[] {
            //    "CTCGATGAGTAGGAAAGTAGTTTCACTGGGCGAACCACCCCGGCGCTAATCCTAGTGCCC",
            //    "GCAATCCTACCCGAGGCCACATATCAGTAGGAACTAGAACCACCACGGGTGGCTAGTTTC",
            //    "GGTGTTGAACCACGGGGTTAGTTTCATCTATTGTAGGAATCGGCTTCAAATCCTACACAG",
            //};
            //var m = p.AllPossibleMedianString(dna, k);

            //var inputFile = "gs\\gs1.txt";
            //var threshold = 63;

            //Parallel.Invoke(
            //    () => { p.InvokeRandomMotifSearch(inputFile, threshold); }, 
            //    () => { p.InvokeRandomMotifSearch(inputFile, threshold); }, 
            //    () => { p.InvokeRandomMotifSearch(inputFile, threshold); }, 
            //    () => { p.InvokeRandomMotifSearch(inputFile, threshold); });

            //var output = p.RandomizedMotifSearch(inputFile);
            //var score = p.GetScore(output);
            //while (score > 62)
            //{
            //    score = p.GetScore(p.RandomizedMotifSearch(inputFile));
            //}
            //var textOutput = string.Join("\n", output.ToArray());


            var inputFile = "gs\\gs3.txt";
            
            Parallel.Invoke(
                () => { p.InvokeGibbsSampler(inputFile, 62); },
                () => { p.InvokeGibbsSampler(inputFile, 62); },
                () => { p.InvokeGibbsSampler(inputFile, 62); },
                () => { p.InvokeGibbsSampler(inputFile, 62); });

            Console.ReadLine();
        }

        public List<string> InvokeGibbsSampler(string inputFile, int threshold)
        {
            var output = InvokeGibbsSampler(inputFile);
            var score = GetScore(output);
            while (score > threshold)
            {
                output = InvokeGibbsSampler(inputFile);
                score = GetScore(output);
            }
            Debug.WriteLine("score: " + score + Environment.NewLine + string.Join("\n", output.ToArray()));
            return output;
        }
        public List<string> InvokeGibbsSampler(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var dna = new List<string>();
            var k = 0;
            var t = 0;
            var N = 0;
            for (var i = 0; i < fileLines.Length; i++)
            {
                if (i == 0)
                {
                    var split = fileLines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    k = Convert.ToInt32(split[0]);
                    t = Convert.ToInt32(split[1]);
                    N = Convert.ToInt32(split[2]);
                }
                else
                {
                    dna.Add(fileLines[i]);
                }
            }

            return InvokeGibbsSampler(dna, k, t, N);
        }
        public List<string> InvokeGibbsSampler(List<string> dna, int k, int t, int N)
        {
            var rnd = new Random();

            var firstMotifs = new List<string>();

            foreach (var s in dna)
            {
                var randomStartIndex = rnd.Next(s.Length - k);
                firstMotifs.Add(s.Substring(randomStartIndex, k));
            }

            var bestMotifs = new List<string>();
            bestMotifs.AddRange(firstMotifs);

            for (var j = 1; j <= N; j++)
            {
                var random = rnd.Next(dna.Count);
                var profile = ConstructGibbsProfileWithPseudocountsFromMotifs(bestMotifs, random);
                var tempMofif = new List<string>();

                foreach (var s in dna)
                {
                    var thisMotif = MostProbableKmerLogic(s, k, profile);
                    tempMofif.Add(thisMotif);
                }

                var tempScore = GetScore(tempMofif);
                var bestScore = GetScore(bestMotifs);
                if (tempScore < bestScore)
                {
                    bestMotifs = tempMofif;
                }
            }
            return bestMotifs;
        }
        public Dictionary<string, Dictionary<int, double>> ConstructGibbsProfileWithPseudocountsFromMotifs(List<string> motifs, int takenOut)
        {
            var returnValue = new Dictionary<string, Dictionary<int, double>>();
            var t = motifs.Count;
            var tWithPseudocount = t + 4;
            var k = motifs.First().Length;

            var motifCopy = new List<string>(motifs);
            motifCopy.RemoveAt(takenOut);

            for (var i = 0; i < 4; i++)
            {
                var innerDictionary = new Dictionary<int, double>();
                for (var j = 0; j < k; j++)
                {
                    var nucleotide = DigitToNucleotide(i);
                    var frequency = motifCopy.Where(x => x.Substring(j, 1) == nucleotide).Count();
                    var frequencyWithPseudoCount = frequency + 1;
                    innerDictionary.Add(j, (double)frequencyWithPseudoCount / tWithPseudocount);
                }
                returnValue.Add(DigitToNucleotide(i), innerDictionary);
            }
            // convert to probability distribution...
            for(var i = 0; i < k; i++)
            {
                var allProbabilities = returnValue.Select(x => x.Value[i]);
                var totalProbabilities = allProbabilities.Sum();
                for (var j = 0; j < 4; j++)
                {
                    var original = returnValue[DigitToNucleotide(j)][i];
                    returnValue[DigitToNucleotide(j)][i] = original / totalProbabilities;
                }
            }
            return returnValue;
        }


        public class ProbabilityDistribution
        {
            public int Number { get; set; }
            public decimal Distribution { get; set; }
            public int Reverse { get; set;}
            public int Marker { get; set; }
        }
        public ProbabilityDistribution NextRandom(List<ProbabilityDistribution> input)
        {
            var marker = 0;
            foreach(var pd in input)
            {
                pd.Reverse = (int) Math.Floor(1 / pd.Distribution);
                marker = marker + pd.Reverse;
                pd.Marker = marker;
            }
            var total = input.Sum(x => x.Reverse);
            var random = new Random();
            var result = random.Next(total) + 1;

            var sortedDistribution = input.OrderBy(x => x.Marker);
            foreach(var pd in input)
            {
                if (result > pd.Marker)
                {
                    return pd;
                }
            }
            return null;
        }

        public List<string> InvokeRandomMotifSearch(string inputFile, int threshold)
        {
            var output = RandomizedMotifSearch(inputFile);
            var score = GetScore(output);
            while(score > threshold)
            {
                output = RandomizedMotifSearch(inputFile);
                score = GetScore(output);
            }
            Debug.WriteLine("score: " + score + Environment.NewLine + string.Join("\n", output.ToArray()));
            return output;
        }

        public List<string> RandomizedMotifSearch(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var dna = new List<string>();
            var k = 0;
            var t = 0;
            for (var i = 0; i < fileLines.Length; i++)
            {
                if (i == 0)
                {
                    var split = fileLines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    k = Convert.ToInt32(split[0]);
                    t = Convert.ToInt32(split[1]);
                }
                else
                {
                    dna.Add(fileLines[i]);
                }
            }

            return RandomizedMotifSearchLogic(dna, k, t);
        }

        public List<string> RandomizedMotifSearchLogic(List<string> dna, int k, int t)
        {
            var rnd = new Random();

            var firstMotifs = new List<string>();

            foreach(var s in dna)
            {
                var randomStartIndex = rnd.Next(s.Length - k);
                firstMotifs.Add(s.Substring(randomStartIndex, k));
            }

            var bestMotifs = new List<string>();
            bestMotifs.AddRange(firstMotifs);

            while (true)
            {
                var profile = ConstructProfileWithPseudocountsFromMotifs(bestMotifs);
                var tempMofif = new List<string>();

                foreach(var s in dna)
                {
                    var thisMotif = MostProbableKmerLogic(s, k, profile);
                    tempMofif.Add(thisMotif);
                }

                var tempScore = GetScore(tempMofif);
                var bestScore = GetScore(bestMotifs);
                if (tempScore < bestScore)
                {
                    bestMotifs = tempMofif;
                }
                else
                {
                    return bestMotifs;
                }
            }
        }

        public List<string> GreedyMotifSearchWithPseudocounts(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var dna = new List<string>();
            var k = 0;
            var t = 0;
            for (var i = 0; i < fileLines.Length; i++)
            {
                if (i == 0)
                {
                    var split = fileLines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    k = Convert.ToInt32(split[0]);
                    t = Convert.ToInt32(split[1]);
                }
                else
                {
                    dna.Add(fileLines[i]);
                }
            }

            // logic starts
            var bestMotifs = new List<string>();
            for (var i = 0; i < t; i++)
            {
                bestMotifs.Add(dna[i].Substring(0, k));
            }
            var length = dna[0].Length - k + 1;
            for (var i = 0; i < length; i++)
            {
                var motifs = new List<string>();
                motifs.Add(dna[0].Substring(i, k));
                for (var j = 1; j < dna.Count(); j++)
                {
                    var profile = ConstructProfileWithPseudocountsFromMotifs(motifs);
                    var mostProbableKmer = MostProbableKmerLogic(dna[j], k, profile);
                    motifs.Add(mostProbableKmer);
                }
                var motifScore = GetScore(motifs);
                var bestMotifScore = GetScore(bestMotifs);
                if (motifScore < bestMotifScore)
                {
                    bestMotifs = motifs;
                }
            }

            return bestMotifs;
        }

        public List<string> GreedyMotifSearch(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var dna = new List<string>();
            var k = 0;
            var t = 0;
            for (var i = 0; i < fileLines.Length; i++)
            {
                if (i == 0)
                {
                    var split = fileLines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    k = Convert.ToInt32(split[0]);
                    t = Convert.ToInt32(split[1]);
                }
                else
                {
                    dna.Add(fileLines[i]);
                }
            }

            // logic starts
            var bestMotifs = new List<string>();
            for (var i = 0; i < t; i++)
            {
                bestMotifs.Add(dna[i].Substring(0, k));
            }
            var length = dna[0].Length - k + 1;
            for (var i = 0; i < length; i++)
            {
                var motifs = new List<string>();
                motifs.Add(dna[0].Substring(i, k));
                for (var j = 1; j < dna.Count(); j++)
                {
                    var profile = ConstructProfileFromMotifs(motifs);
                    var mostProbableKmer = MostProbableKmerLogic(dna[j], k, profile);
                    motifs.Add(mostProbableKmer);
                }
                var motifScore = GetScore(motifs);
                var bestMotifScore = GetScore(bestMotifs);
                if (motifScore < bestMotifScore)
                {
                    bestMotifs = motifs;
                }
            }
            
            return bestMotifs;
        }

        public Dictionary<string, Dictionary<int, double>> ConstructProfileWithPseudocountsFromMotifs(List<string> motifs)
        {
            var returnValue = new Dictionary<string, Dictionary<int, double>>();
            var t = motifs.Count;
            var tWithPseudocount = t + 4;            
            var k = motifs.First().Length;

            for (var i = 0; i < 4; i++)
            {
                var innerDictionary = new Dictionary<int, double>();
                for (var j = 0; j < k; j++)
                {
                    var nucleotide = DigitToNucleotide(i);
                    var frequency = motifs.Where(x => x.Substring(j, 1) == nucleotide).Count();
                    var frequencyWithPseudoCount = frequency + 1;
                    innerDictionary.Add(j, (double) frequencyWithPseudoCount / tWithPseudocount);
                }
                returnValue.Add(DigitToNucleotide(i), innerDictionary);
            }
            return returnValue;
        }

        public Dictionary<string, Dictionary<int, double>> ConstructProfileFromMotifs(List<string> motifs)
        {
            var returnValue = new Dictionary<string, Dictionary<int, double>>();
            var t = motifs.Count;
            var k = motifs.First().Length;

            for(var i = 0; i < 4; i++)
            {
                var innerDictionary = new Dictionary<int, double>();
                for(var j = 0; j < k; j++)
                {
                    var nucleotide = DigitToNucleotide(i);
                    var frequency = motifs.Where(x => x.Substring(j, 1) == nucleotide).Count();
                    innerDictionary.Add(j, (((double)frequency) / t));
                }
                returnValue.Add(DigitToNucleotide(i), innerDictionary);
            }
            return returnValue;            
        }

        public string GetConsensus(List<string> motifs)
        {
            if (motifs.Count == 0)
            {
                return "";
            }
            if (motifs.Count() == 1)
            {
                return motifs.First();
            }

            var profile = ConstructProfileFromMotifs(motifs);

            var k = motifs.First().Length;
            var sb = new StringBuilder();
            for(var i = 0; i < k; i++)
            {
                var kvps = profile.Select(x => x.Value[i]);
                var max = kvps.Max();
                var stringConsensus = profile.Where(x => x.Value[i] == max).Select(x => x.Key);
                sb.Append(stringConsensus.FirstOrDefault());
            }
            return sb.ToString();
        }

        public int GetScore(List<string> motifs)
        {
            var consensus = GetConsensus(motifs);
            if (motifs.Count == 0)
            {
                return 0;
            }
            var score = 0;
            foreach(var m in motifs)
            {
                var distance = CalculateHammingDistance(consensus, m);
                score = score + distance;
            }
            return score;
        }

        public string MostProbableKmer(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var text = "";
            var k = 0;
            var profile = new Dictionary<string, Dictionary<int, double>>();
            for (var i = 0; i < fileLines.Length; i++)
            {
                if (i == 0)
                {
                    text = fileLines[i];
                }
                else if (i == 1)
                {
                    k = Convert.ToInt32(fileLines[i]);
                }
                else if (i >= 2 && i <= 5) 
                {
                    var splitProbabilities = fileLines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var rowDictionary = new Dictionary<int, double>();
                    for (var j = 0; j < splitProbabilities.Length; j++)
                    {
                        rowDictionary.Add(j, Convert.ToDouble(splitProbabilities[j]));
                    }
                    profile.Add(DigitToNucleotide(i - 2), rowDictionary);
                }
            }

            return MostProbableKmerLogic(text, k, profile);
            //var allPatterns = AllPossiblePattern(text, k);
            //var mostProbable = "";
            //var tempProbability = double.MinValue;

            //for(var i = 0; i < allPatterns.Count; i++)
            //{
            //    var pattern = allPatterns[i];
            //    var p = profile[pattern.Substring(0, 1)][0];
            //    for(var j = 1; j < pattern.Length; j++)
            //    {
            //        p = p * profile[pattern.Substring(j, 1)][j];
            //    }
            //    if (tempProbability < p)
            //    {
            //        tempProbability = p;
            //        mostProbable = pattern;
            //    }
            //}

            //return mostProbable;
        }

        private string MostProbableKmerLogic(string text, int k, Dictionary<string, Dictionary<int, double>> profile)
        {
            var allPatterns = AllPossiblePattern(text, k);
            var mostProbable = "";
            var tempProbability = double.MinValue;

            for (var i = 0; i < allPatterns.Count; i++)
            {
                var pattern = allPatterns[i];
                var p = profile[pattern.Substring(0, 1)][0];
                for (var j = 1; j < pattern.Length; j++)
                {
                    p = p * profile[pattern.Substring(j, 1)][j];
                }
                if (tempProbability < p)
                {
                    tempProbability = p;
                    mostProbable = pattern;
                }
            }

            return mostProbable;
        }

        public List<string> AllPossibleMedianString(string[] dna, int k)
        {
            var median = new List<string>();
            var distance = int.MaxValue;
            for (var i = 0; i < Math.Pow(4, k); i++)
            {
                var pattern = NumberToPattern(i, k);
                var tempd = DistanceBetweenPatternAndString(pattern, dna);
                if (distance >= tempd)
                {
                    distance = tempd;
                    median.Add(pattern);
                }
            }
            return median;
        }

        public string MedianString(string[] dna, int k)
        {
            var median = "";
            var distance = int.MaxValue;
            for(var i = 0; i < Math.Pow(4, k); i++)
            {
                var pattern = NumberToPattern(i, k);
                var tempd = DistanceBetweenPatternAndString(pattern, dna);
                if (distance > tempd)
                {
                    distance = tempd;
                    median = pattern;
                }
            }
            return median;
        }

        public int DistanceBetweenPatternAndString(string pattern, string[] dna)
        {
            var k = pattern.Length;

            var distance = 0;

            foreach (var text in dna)
            {
                var hammingDistance = int.MaxValue;

                var allPatternsInText = AllPossiblePattern(text, k);
                foreach (var p in allPatternsInText)
                {
                    var tempd = CalculateHammingDistance(pattern, p);
                    if (hammingDistance > CalculateHammingDistance(pattern, p))
                    {
                        hammingDistance = tempd;
                    }
                }
                distance = distance + hammingDistance;
            }

            return distance;
        }

        public List<string> MotifEnumeration(string[] dna, int k, int d)
        {
            var patterns = new List<string>();

            foreach(var s in dna)
            {
                var fw = FrequentWords(s, k);
                foreach(var p in fw)
                {
                    var neighborsOfP = Neighbors(p, d);
                    foreach(var n in neighborsOfP)
                    {
                        var shouldInsert = true;
                        foreach(var s2 in dna)
                        {
                            if (ApproximatePatternCount(s2, n, d) <= 0)
                            {
                                shouldInsert = false;
                                continue;
                            }
                        }
                        if (shouldInsert)
                        {
                            patterns.Add(n);
                        }
                    }
                }
            }

            return patterns.Distinct().ToList();
        }

        public List<string> FrequentWordsWithMismatchesAndComplement(string input, int patternLength, int maxHammingDistance)
        {
            var frequentPatterns = new List<string>();
            var neighborhoods = new List<string>();

            for (var i = 0; i <= input.Length - patternLength; i++)
            {
                neighborhoods.AddRange(Neighbors(input.Substring(i, patternLength), maxHammingDistance));
            }

            // reverse complement
            var reverseInput = ReverseComplement(input);
            for (var i = 0; i <= reverseInput.Length - patternLength; i++)
            {
                neighborhoods.AddRange(Neighbors(reverseInput.Substring(i, patternLength), maxHammingDistance));
            }

            var index = new List<long>();
            var count = new List<int>();
            for (var i = 0; i < neighborhoods.Count; i++)
            {
                var pattern = neighborhoods[i];
                index.Add(PatternToNumber(pattern));
                count.Add(1);
            }

            index = index.OrderBy(x => x).ToList();
            for (var i = 0; i < neighborhoods.Count - 1; i++)
            {
                if (index[i] == index[i + 1])
                {
                    count[i + 1] = count[i] + 1;
                }
            }

            var max = count.Max();

            for (var i = 0; i < neighborhoods.Count; i++)
            {
                if (count[i] == max)
                {
                    frequentPatterns.Add(NumberToPattern(index[i], patternLength));
                }
            }

            return frequentPatterns.Where(s => !string.IsNullOrEmpty(s)).ToList();
        }

        public List<string> FrequentWordsWithMismatches(string input, int patternLength, int maxHammingDistance)
        {
            var frequentPatterns = new List<string>();
            var neighborhoods = new List<string>();

            for (var i = 0; i <= input.Length - patternLength; i++)
            {
                neighborhoods.AddRange(Neighbors(input.Substring(i, patternLength), maxHammingDistance));
            }

            var index = new List<long>();
            var count = new List<int>();
            for (var i = 0; i < neighborhoods.Count; i++)
            {
                var pattern = neighborhoods[i];
                index.Add(PatternToNumber(pattern));
                count.Add(1);
            }

            index = index.OrderBy(x => x).ToList();
            for (var i = 0; i < neighborhoods.Count - 1; i++)
            {
                if (index[i] == index[i + 1])
                {
                    count[i + 1] = count[i] + 1;
                }
            }

            var max = count.Max();
            for (var i = 0; i < neighborhoods.Count; i++)
            {
                if (count[i] == max)
                {
                    frequentPatterns.Add(NumberToPattern(index[i], patternLength));
                }
            }

            return frequentPatterns.Where(s => !string.IsNullOrEmpty(s)).ToList();
        }

        public List<string> Neighbors(string pattern, int maxHammingDistance)
        {
            if (maxHammingDistance <= 0)
            {
                return new List<string>() { pattern };
            }

            if (pattern.Length == 1)
            {
                return AllNucleotides();
            }

            var neighborhood = new List<string>();

            var suffixNeighbors = Neighbors(pattern.Substring(1), maxHammingDistance);

            foreach (var s in suffixNeighbors)
            {
                if (CalculateHammingDistance(pattern.Substring(1), s) < maxHammingDistance)
                {
                    // less than max distance, so prefixing s with any nucleotide is still less than max distance
                    foreach (var n in AllNucleotides())
                    {
                        neighborhood.Add(n + s);
                    }
                }
                else
                {
                    neighborhood.Add(pattern.Substring(0, 1) + s);
                }
            }

            return neighborhood;
        }

        public int[] CalculateSkew(string input)
        {
            var current = 0;
            var returnedList = new List<int>();
            returnedList.Add(current);
            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input.Substring(i, 1);
                if (currentChar == "G")
                {
                    current++;
                    returnedList.Add(current);
                }
                else if (currentChar == "C")
                {
                    current--;
                    returnedList.Add(current);
                }
                else
                {
                    returnedList.Add(current);
                }
            }
            return returnedList.ToArray();
        }

        public int[] FindMinimum(int[] input)
        {
            var currentMin = 0;
            var returnedList = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentValue = input[i];
                if (currentValue < currentMin)
                {
                    currentMin = currentValue;
                    returnedList = new List<int>();
                    returnedList.Add(i);
                }
                else if (currentValue == currentMin)
                {
                    returnedList.Add(i);
                }
                else
                {

                }
            }

            return returnedList.ToArray();
        }

        public int[] FindMaximum(int[] input)
        {
            var currentMax = 0;
            var returnedList = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentValue = input[i];
                if (currentValue > currentMax)
                {
                    currentMax = currentValue;
                    returnedList = new List<int>();
                    returnedList.Add(i);
                }
                else if (currentValue == currentMax)
                {
                    returnedList.Add(i);
                }
                else
                {

                }
            }

            return returnedList.ToArray();
        }

        public int CalculateHammingDistance(string input1, string input2)
        {
            if (input1.Length != input2.Length)
            {
                throw new ArgumentException("wrong length");
            }

            var distance = 0;
            for (var i = 0; i < input1.Length; i++)
            {
                if (input1[i] != input2[i])
                {
                    distance++;
                }
            }
            return distance;
        }

        public List<string> ClumpFinding(string input, int patternLength, int clumpThreshold, int windowSize)
        {
            var returnedResult = new List<string>();

            if (string.IsNullOrEmpty(input) || patternLength <= 0 || clumpThreshold <= 0 || windowSize <= 0)
            {
                return returnedResult;
            }

            var clumpDictionary = new Dictionary<long, int>();
            for (var i = 0; i < Math.Pow(4, patternLength); i++)
            {
                clumpDictionary.Add(i, 0);
            }

            // starting window
            var windowText = input.Substring(0, windowSize);

            var frequencyArray = ComputingFrequencies(windowText, patternLength);

            for (var i = 0; i < clumpDictionary.Count; i++)
            {
                if (frequencyArray[i] >= clumpThreshold)
                {
                    clumpDictionary[i] = 1;
                }
            }

            // start at 1 because first one already done
            for (var i = 1; i <= input.Length - windowSize; i++)
            {
                var firstPattern = input.Substring(i - 1, patternLength);

                var dictionaryIndex = PatternToNumber(firstPattern);
                frequencyArray[dictionaryIndex] = frequencyArray[dictionaryIndex] - 1;

                var lastPattern = input.Substring(i + windowSize - patternLength, patternLength);
                dictionaryIndex = PatternToNumber(lastPattern);
                frequencyArray[dictionaryIndex] = frequencyArray[dictionaryIndex] + 1;

                if (frequencyArray[dictionaryIndex] >= clumpThreshold)
                {
                    clumpDictionary[dictionaryIndex] = 1;
                }
            }

            var clumps = clumpDictionary.Where(kvp => kvp.Value == 1);

            return clumps.Select(x => NumberToPattern(x.Key, patternLength)).ToList();
        }

        public Dictionary<long, int> ComputingFrequencies(string input, int patternLength)
        {
            var returnedList = new Dictionary<long, int>();
            if (string.IsNullOrEmpty(input) || patternLength <= 0)
            {
                return returnedList;
            }

            for (var i = 0; i < Math.Pow(4, patternLength); i++)
            {
                returnedList.Add(i, 0);
            }

            for (var i = 0; i <= input.Length - patternLength; i++)
            {
                string pattern = input.Substring(i, patternLength);

                var number = PatternToNumber(pattern);
                returnedList[number] = returnedList[number] + 1;
            }

            return returnedList;
        }

        public int ApproximatePatternCount(string input, string pattern, int maxHammingDistance)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            if (string.IsNullOrEmpty(pattern))
            {
                return 0;
            }

            var count = 0;
            var patternLength = pattern.Length;
            for (var i = 0; i <= input.Length - patternLength; i++)
            {
                if (CalculateHammingDistance(input.Substring(i, patternLength), pattern) <= maxHammingDistance)
                {
                    count++;
                }
            }

            return count;
        }

        public int PatternCount(string input, string pattern)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            if (string.IsNullOrEmpty(pattern))
            {
                return 0;
            }

            var count = 0;
            var patternLength = pattern.Length;
            for (var i = 0; i <= input.Length - patternLength; i++)
            {
                if (input.Substring(i, patternLength) == pattern)
                {
                    count++;
                }
            }

            return count;
        }

        public List<int> PatternMatchingWithinHammingDistance(string pattern, string input, int maxHammingDistance)
        {

            if (string.IsNullOrEmpty(input))
            {
                return new List<int>();
            }
            if (string.IsNullOrEmpty(pattern))
            {
                return new List<int>();
            }

            var patternLength = pattern.Length;
            var returnedList = new List<int>();

            for (var i = 0; i <= input.Length - patternLength; i++)
            {
                if (CalculateHammingDistance(input.Substring(i, patternLength), pattern) <= maxHammingDistance)
                {
                    returnedList.Add(i);
                }
            }

            return returnedList;
        }

        public List<int> PatternMatching(string pattern, string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return new List<int>();
            }
            if (string.IsNullOrEmpty(pattern))
            {
                return new List<int>();
            }

            var patternLength = pattern.Length;
            var returnedList = new List<int>();

            for (var i = 0; i <= input.Length - patternLength; i++)
            {
                if (input.Substring(i, patternLength) == pattern)
                {
                    returnedList.Add(i);
                }
            }

            return returnedList;
        }
        
        public List<string> FrequentWords(string input, int patternLength)
        {
            if (string.IsNullOrEmpty(input) || patternLength <= 0)
            {
                return new List<string>();
            }

            var returnedList = new List<string>();
            var indexCountDictionary = new Dictionary<int, int>();

            for (var i = 0; i <= input.Length - patternLength; i++)
            {
                var pattern = input.Substring(i, patternLength);
                var patternCount = PatternCount(input, pattern);
                indexCountDictionary.Add(i, patternCount);
            }

            var max = indexCountDictionary.Values.Max();

            for (var i = 0; i <= input.Length - patternLength; i++)
            {
                if (indexCountDictionary[i] == max)
                {
                    returnedList.Add(input.Substring(i, patternLength));
                }
            }

            returnedList = returnedList.Distinct().OrderBy(x => x).ToList();
            return returnedList;
        }

        public List<string> AllPossiblePattern(string text, int length)
        {
            var patterns = new List<string>();
            for(var i = 0; i <= text.Length - length; i++)
            {
                patterns.Add(text.Substring(i, length));
            }
            return patterns;
        }

        // helpers
        public string ReverseComplement(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            for (var i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(GetNucleotideComplement(input.Substring(i, 1).ToUpper(CultureInfo.InvariantCulture)));
            }
            return sb.ToString();
        }

        public long PatternToNumber(string pattern)
        {
            if (string.IsNullOrEmpty(pattern))
            {
                return 0;
            }

            var length = pattern.Length;

            var number = (long)0;
            for (var i = 0; i < pattern.Length; i++)
            {
                number = number + (NucleotideToDigit(pattern.Substring(i, 1)) * (long)Math.Pow(4, pattern.Length - 1 - i));
            }

            return number;
        }

        public string NumberToPattern(long number, int length)
        {
            if (number < 0)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();

            while (length > 0)
            {
                var divisor = Math.Pow(4, length - 1);
                var currentDigit = Math.Floor(number / Math.Pow(4, length - 1));
                var remainder = number % divisor;

                sb.Append(DigitToNucleotide((int)currentDigit));
                number = (long)remainder;
                length = length - 1;
            }

            return sb.ToString();
        }

        protected int NucleotideToDigit(string nucleotide)
        {
            switch (nucleotide)
            {
                case "A":
                    return 0;
                case "C":
                    return 1;
                case "G":
                    return 2;
                case "T":
                    return 3;
                default:
                    return -1;
            }
        }

        protected string DigitToNucleotide(int digit)
        {
            switch (digit)
            {
                case 0:
                    return "A";
                case 1:
                    return "C";
                case 2:
                    return "G";
                case 3:
                    return "T";
                default:
                    return "A";
            }
        }

        protected string GetNucleotideComplement(string input)
        {
            switch (input)
            {
                case "A":
                    return "T";
                case "T":
                    return "A";
                case "C":
                    return "G";
                case "G":
                    return "C";
                default:
                    return "";
            }
        }

        protected List<string> AllNucleotides()
        {
            return new List<string>() { "A", "T", "C", "G" };
        }
    }
}
