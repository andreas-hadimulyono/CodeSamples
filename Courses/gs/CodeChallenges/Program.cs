using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MoreLinq;
using System.Diagnostics;
using System.Globalization;

namespace CodeChallenges
{
    public class Program
    {
        public const int CodonLength = 3;
        public static Dictionary<string, string> CodonTable;
        public static Dictionary<string, int> AminoAcidMass;

        public Program()
        {
            CodonTable = new Dictionary<string, string>();
            CodonTable.Add("AAA", "K");
            CodonTable.Add("AAC", "N");
            CodonTable.Add("AAG", "K");
            CodonTable.Add("AAU", "N");
            CodonTable.Add("ACA", "T");
            CodonTable.Add("ACC", "T");
            CodonTable.Add("ACG", "T");
            CodonTable.Add("ACU", "T");
            CodonTable.Add("AGA", "R");
            CodonTable.Add("AGC", "S");
            CodonTable.Add("AGG", "R");
            CodonTable.Add("AGU", "S");
            CodonTable.Add("AUA", "I");
            CodonTable.Add("AUC", "I");
            CodonTable.Add("AUG", "M");
            CodonTable.Add("AUU", "I");
            CodonTable.Add("CAA", "Q");
            CodonTable.Add("CAC", "H");
            CodonTable.Add("CAG", "Q");
            CodonTable.Add("CAU", "H");
            CodonTable.Add("CCA", "P");
            CodonTable.Add("CCC", "P");
            CodonTable.Add("CCG", "P");
            CodonTable.Add("CCU", "P");
            CodonTable.Add("CGA", "R");
            CodonTable.Add("CGC", "R");
            CodonTable.Add("CGG", "R");
            CodonTable.Add("CGU", "R");
            CodonTable.Add("CUA", "L");
            CodonTable.Add("CUC", "L");
            CodonTable.Add("CUG", "L");
            CodonTable.Add("CUU", "L");
            CodonTable.Add("GAA", "E");
            CodonTable.Add("GAC", "D");
            CodonTable.Add("GAG", "E");
            CodonTable.Add("GAU", "D");
            CodonTable.Add("GCA", "A");
            CodonTable.Add("GCC", "A");
            CodonTable.Add("GCG", "A");
            CodonTable.Add("GCU", "A");
            CodonTable.Add("GGA", "G");
            CodonTable.Add("GGC", "G");
            CodonTable.Add("GGG", "G");
            CodonTable.Add("GGU", "G");
            CodonTable.Add("GUA", "V");
            CodonTable.Add("GUC", "V");
            CodonTable.Add("GUG", "V");
            CodonTable.Add("GUU", "V");
            CodonTable.Add("UAA", "");
            CodonTable.Add("UAC", "Y");
            CodonTable.Add("UAG", "");
            CodonTable.Add("UAU", "Y");
            CodonTable.Add("UCA", "S");
            CodonTable.Add("UCC", "S");
            CodonTable.Add("UCG", "S");
            CodonTable.Add("UCU", "S");
            CodonTable.Add("UGA", "");
            CodonTable.Add("UGC", "C");
            CodonTable.Add("UGG", "W");
            CodonTable.Add("UGU", "C");
            CodonTable.Add("UUA", "L");
            CodonTable.Add("UUC", "F");
            CodonTable.Add("UUG", "L");
            CodonTable.Add("UUU", "F");

            AminoAcidMass = new Dictionary<string, int>();
            AminoAcidMass.Add("G", 57);
            AminoAcidMass.Add("A", 71);
            AminoAcidMass.Add("S", 87);
            AminoAcidMass.Add("P", 97);
            AminoAcidMass.Add("V", 99);
            AminoAcidMass.Add("T", 101);
            AminoAcidMass.Add("C", 103);
            AminoAcidMass.Add("I", 113);
            AminoAcidMass.Add("L", 113);
            AminoAcidMass.Add("N", 114);
            AminoAcidMass.Add("D", 115);
            AminoAcidMass.Add("K", 128);
            AminoAcidMass.Add("Q", 128);
            AminoAcidMass.Add("E", 129);
            AminoAcidMass.Add("M", 131);
            AminoAcidMass.Add("H", 137);
            AminoAcidMass.Add("F", 147);
            AminoAcidMass.Add("R", 156);
            AminoAcidMass.Add("Y", 163);
            AminoAcidMass.Add("W", 186);
        }

        static void Main(string[] args)
        {
            var p = new Program();

            // assignment 1: create all possible k-mer of length k in text
            //var inputFile = "CreateComposition/cc1.txt";
            //var output = p.CreateComposition(inputFile);
            //Debug.WriteLine("");
            //foreach(var s in output)
            //{
            //    Debug.WriteLine(s);
            //}

            //Console.ReadLine();

            // assignment 2: assemble genome string from genome path
            //var inputFile = "GenomePath/gc.txt";
            //var output = p.GenomePathStringReconstruction(inputFile);
            //Debug.WriteLine("");
            //Debug.WriteLine(output);
            //Console.ReadLine();

            // assignment 3: create adjacency list for overlap graph problem
            //var inputFile = "OverlapGraph/aj.txt";
            //var output = p.CreateOverlapAdjacencyList(inputFile);
            //Debug.WriteLine("");
            //foreach (var s in output)
            //{
            //    Debug.WriteLine(s);
            //}
            //Console.ReadLine();

            // assignment 4: creating De Bruijn graph from string
            //var inputFile = "DBGraph/dbg.txt";
            //var output = p.CreateDeBruijnGraph(inputFile);
            //Debug.WriteLine("");
            //foreach (var s in output)
            //{
            //    Debug.WriteLine(s);
            //}
            //Console.ReadLine();

            // assignment 5: creating De Bruijn graph from list of patterns
            //var inputFile = "DBGraph/dbg2.txt";
            //var output = p.CreateDeBruijnGraphFromPatterns(inputFile);
            //Debug.WriteLine("");
            //foreach (var s in output)
            //{
            //    Debug.WriteLine(s);
            //}
            //Console.ReadLine();

            // assignment 6: solving directed graph eulerian cycle
            //var inputFile = "Eulerian/ec1.txt";
            //p.Log("new execution at " + DateTime.Now.ToString());
            //var output = p.ConstructEulerianCycleFromAdjacencies(inputFile);
            //Debug.WriteLine("");
            //Debug.WriteLine(output);
            //Console.ReadLine();

            // assignment 7: find eulerian path
            //var inputFile = "Eulerian/ep.txt";
            //var output = p.ConstructEulerianPathFromAdjacencies(inputFile);
            //Debug.WriteLine("");
            //Debug.WriteLine(output);
            //Console.ReadLine();

            // assignment 8: construct eulerian path from patterns
            //var inputFile = "Eulerian/epp.txt";
            //var output = p.ConstructEulerianPathFromPatterns(inputFile);
            //Debug.WriteLine("");
            //Debug.WriteLine(output);
            //Console.ReadLine();

            // assignment 9: universal k strings
            //var inputNumber = 9;
            //var output = p.ConstructUniversalStrings(inputNumber);
            //Debug.WriteLine("");
            //Debug.WriteLine(output);
            //Console.ReadLine();

            // charging stations: StringSpelledByGappedPatterns
            //var inputFile = "Eulerian/p1.txt";
            //var output = p.StringSpelledByGappedPatterns(inputFile);
            //Debug.WriteLine("");
            //Debug.WriteLine(output);
            //Console.ReadLine();

            // assignment 10: construct string from paired patterns
            //var inputFile = "Eulerian/p2.txt";
            //var output = p.StringReconstructionFromReadPairs(inputFile);
            //Debug.WriteLine("");
            //Debug.WriteLine(output);
            //Console.ReadLine();

            // charging stations: MaximalNonBranchingPaths
            // use eulerian nodes
            //var inputFile = "Eulerian/p3.txt";
            //var output = p.MaximalNonBranchingPaths(inputFile);
            //Debug.WriteLine("");
            //foreach (var s in output)
            //{
            //    Debug.WriteLine(s);
            //}
            //Console.ReadLine();

            // assignment 11: Contig Generation from Pattern
            //var inputFile = "Eulerian/p4.txt";
            //var output = p.ContigGenerationFromPatterns(inputFile);
            //Debug.WriteLine("");
            //foreach (var s in output)
            //{
            //    Debug.WriteLine(s);
            //}
            //Console.ReadLine();

            // quiz week 2
            //var inputFile = "Quiz/w2q1.txt";
            //var output = p.ConstructEulerianPathFromPatterns(inputFile);
            //Debug.WriteLine("");
            //Debug.WriteLine(output);
            //Console.ReadLine();

            //var inputFile = "Quiz/w2q3.txt";
            //var output = p.StringReconstructionFromReadPairs(inputFile);
            //Debug.WriteLine("");
            //Debug.WriteLine(output);
            //Console.ReadLine();

            // week 3
            // assignment 12: codon translation
            //var input = "AUGUUUAAGUUAUAUAGUCUGGCCCCAACCCCCCAGUCGCUUUGCGCUCUUAGGAGAGACACCUGCCCUCUUGUAGAAAAAUGUCGGAUCCAAUGUCUACCGUUCGGUUGGUCAUCAUGGUGCGUCCGUAAUUCAGCACUGCGUUUACACGACUAUUUUUAUGCUGUACGGUGUCACCCAUUCUGCUGGGACUUUCGGACUGAUUUGUACAUAGGUUACCGUCUUUCACACGCCAAGGCCAUCUCCCAUAGUCGCGAGUUCGCAUACAUCUGGUCCAACCUUGCGACAACCGUGGCUAUGAUCGAUAUCUUACACGGCCAUGAUACGAAAAUGGUGCCGGGAUCGCUAUCAAGUUCUCACGGUACAUAUACGGGGCACACAGCUGCCGGUCGCUCAACGCGUCUCUCUGUGUUUAAUCCGAGCGAGAAGUAUACUCGUAGGACGGCAAGUCCGGCCAGUCGAGCGUUUAGAGAUCUGGGUGAGCAGAAGGAAUGGAACGAAUGCUGUCUACUCUGUUGCCUAUUCUCGGACUCUGAGUUUGUUCAUGACAACAUUGGUUCCCCCGUUGGACCUCGCGAGAUGGUAUGGUUACGCUGUAGUGGUGGUCCCGCUAACCUUGGCAUCAAGCCGUAUGGGGGGGAAGGUCUCCAACUUUUCAGCAUGGAAACGGCUCUCACUCAAUUCACCCCUCGAUCAGAACGGCUAGAAUUGUCAGGUAGUCUUCUUCCUACUCAUGGUGUAUUGGCGACGACCAUUUUCACCCCUGCAGGGAGACAAGAAAUUGCGGACUUGACGGGUAAUGGAGCAAGCUCGGGCAUCUACCAGUCUCUUGGAUGUGCAUUUUGCACCCAAAGAAAUCGUCACGCCGCAGCUAGUAUGAGACACUACCCUGGUGCUUCCAGCGCUCCAAGGGAGAACGGGUGGGCCUUGGCGGCAAUCGUCAUACUCCGAGUCAGAUUAUCGGAAUUAGCGGGCAUCUUCGGAUCACGACACCCGAUAGCGGCUAUAAACCUGGUUACAGCUCCCGCCGUUGGUUGCGGGCUGAAGAAGGAUUUCAUAAAUUCAUAUGUUCAUUCAGCAAAGCACGUUAUGAGCCGAAAAUCAAUCUUCCCUGAAAAACUGCGUGAUGUCGCCAGCCUGAAAAUCAACUUAACAUUUAGUUCUGACCGAGUUGUGCGUGUUUACUUUAUGCAAAUUCUAGGCCCUCAUGGGCGUGAAGUAUGUUGUAUACUACUAAUCAAGGUCACGGUCGGUACUUGUCUAAACAGCGCGGUACCAUGCGCUGUCUGUCUGUCGUACGGUUGCUGCGGCCUUGGGUUACUUAUGAUGGAUCCCGUUCAGGGCCGAGAUCAUUGGUACCAGUGGCCCUGCGAGAUUGUACCAGCAACAACACCGGUAGGGGCGAUUCCAUCGAAUUGCGGUCCCAGCGCAGGAGAGAAAUUUCGUAGGACAGUGCAAGAUGUCCUUUGCGGUCAAAUGGUCUCCCUGAUUGCCCAGGUAGUGCUAUUGCUCGGUACAACAAGCGGCAUUGUCCAGCCGGGGUCCUGCGCUCAACCUCAAACUCUUUUGGAUGCCGUCCGACAUAGUCACUGUCUAACGCAACGGUUGAAGGCAAUACCUUUAUCGCUAGGCUCGUUAUGGAGAGUUCACUAUGUUCCCAAGAGAUGGUUGAAGCUACUUUGCACCUAUCAAUGUCAAGAUAUCAGAACUCCGCAUGGGGGUUCGUUGCCAGACCUCAACUCGCAAAGGUCGGACGGGAUAGGUGUUUUUCAUCGGCUCUCGAGUACAGGUCAGAUACUCGGUACACCUUUAGUAGACACGCCUCACCACCUCGUCCGAUCGUCUGUACUGAACAUUAGGUGGUUCAACCAAGUUGUUCAGACCCACUGCAUCUCUGGAUUUCGGACCGUCUGCCUAGAGAAUCCAUGGACUUGCUCAGGCGGGGGAACAACUCCAGGUGGUACGCGGUGGCAGGUGCUGGGGCAUAAGCGACCACGGGUUAGCUAUCUCUGCAAAAUAGUAGAACCACGUGUGAAGAGCUGGAAUACCCCUUUUUCGCUAUCUUGCUAUAGAGAAAUCAACAUUGAGACCGGAUACACUUUUGCGGCUCUAUUUAUAUCGCUUUAUUGUGCCGUUGCGUUUAUAGACGGCUUAUUAAAACCAGUAAGUACUUUGGCGCAAAUCGAGACCAUCAAUCCCGUUCUGACGAACCACGGAGGGGUGCCCAGAUUGCUUAAUACUCUUAACAGUUGCUGGAUAUCCCCGCGCGCUGCAUCGGCAAGGAUUAGUCCCUUGCCCAAGCCUAUAUCUAACGAAAAUACAGUAAACCACACCCUGUCUUCGGCGUUAUUUUUGGUUGUUCAACCAAGAAGCUCUAACGGUGCGAGCAGAGACAAGUGGCAUGUAUUACCACUGGCCAGUAGAUAUAUCGAGACGAACGUGAUUAAUAAAAUGUCAUAUCGAGGUAUUAGUAUGAUCGAGCUCAGUUUUCUGGUCAAACCUAUCAUGGUGACAUGCGAGUCAGUUAAGCAAAGGAAACUAAUCUGUUUGCCUAGAGUAUAUCGUCCUCGGACAACGCGGGCUGCCGGACUGGUGGUGGCUAACCGGAUGAUUACCGGGAAACCGAUUAGGACGACUCAUCUGUCAGACACUCUCACCGUAGAAAGAGACCGGGAGAAGAGUAGACCUCCGGACAAACGAGACUACCCCCCCGCCUAUGACAUCCCAAAUGCCGGUUCAUUUUCGCUAUCUAUUUUGGAGGCCCGCGGAUUACCCCAACAGGGAGUCGUUGCUGGAUGCUUUUAUGCUGUCACAAGCGCAGUCCGCAUGGUUGGGUUGCGCGAGGCGCUCCGACGGCUGUGUAAUUCCGUAUUUGUUGUAAGUGAACGAACUUACCAAGGUGGAGACAGAAGUAAUUGCGUUAUAAUCGAUAGCCAAUCUCGAUGCCGAACUUCCAGAAUUCGCAAGUACCGUCGCAGGUCUUCGAAACGUGUAUACAACAAUUACACACCCCUUCCUCGCCGUGAGAACUUGUUUACCCCCGGUUUUUCAGAAGCGCGGUUGCUUGUAUGCCGCGGUUUAGUCAGUUGUGAGAUCGGGUGCCCUUCCUCAUACAGUUGCGUUUUUUAUCGUCCGAGUCUGGAGAGACUAAUGGUAUGUCAGUUUUUUUCAGACUAUUCCUAUGUGGCCGAAGCAUCGACAAGAACGAAACCAGGCACUGUGUCCUCCACUGUGGACAGAAAGGACUGGUCAACACUUGCUUUGGUAAGGAGGGCCAACCUAAUCGUCUCGAUCCGUGGUAUCGAGACAGGGACAAACUUUGGCCCACAUGUAAAAGGAAAUGACAUUUUUCUAUCCCAUUUGACACAGACUGCAAUAGUUUGCUUGGACUCGGAUGCCCUAGUCAUAAGGCGAUGCCUCCCUAGUUCGAAAGAAACUUACAAAGCCGUACAAGCACCAGAUACUCAACCAAUGAUACAGAUGAUUGUGGAAGACGGUAUUCAAGAGUCACCGAUGUGGAGGUGGGUAGUCUUGUCCCAGUGGUCUGGCGACACCAGGCAUUCACCGGUGACGUGCCAUAAAGUUGAACCACCUGACGGCAAAGAUUUGCCAGGAACUAUGACGAUGUAUGACGUGUUAUCAGGCAUCUUUCCUAUUAAGAUACUCAACCUCGUUCAGUUGACGGAGCAUGUUGUCAAUUCGUCACCUGUUCGAGAGACCCUCCCACCGGUCGUGUUGUAUCUUUCCGAGAGGUACCACAUUUGGGACUCUGUCCCGCCUAGUGUCCUUCAGGGUAGUUUGCAUAAUGUUGACGUCAGUAAUGGGGGUAAUCACGUCGAAAGGGCCUGUCGUGCUCUACUUGAAACCAACGGGAGCCGUGUCUAUUCAAUAAUGUCCAAAUUGUUGCGCGGGCUAGCCAUGCACCAGAACCAACCAUCGCCAAACAAUCUGCGAUUGCUUAAGCUGGCCGUAGUGGCUACCCUACCCGGCACGAAAACAACCCGACUGGGGGCCGACGCUCUACGCCAGCCUCUGCAGGGAUGCCCAUACCAAAUUAACUGCGAUUAUUUCGUAACGUCUUGCUUCCCCCGCCUUUGCGAUCAGUUGGCCCUGUUGGCGAGGUUGCUCUCCGCUCCGCGGGGCCACAGGAGAAUCCCGGGGAGGAGGUACCGACGUUUAGUAUUUUGUAAGAUUUUACCACAACGAUUCCUAAUGUGUGUCACAUUAGCAGUGAUGAUUAGAGGGGUAUCCAACCAGCUUGCUUCGAUCAUUGCCCACUAUCUUACUACGGCACGACAAUUGAUGUACGUAGGCUCGCUUGACGCACCCUUGCGUGCCAGGCGAACGAAACUGUCUGCCUACUUUAGGGUACGUAGGACCCCCGUCUGCAUAAGACACGCAAAAUCGUUUGUCUGUCAAAGAGCUUGCCCCGAUGUUACCUUACCGCUGACUCAUCGCGUGUUAGCAUCCCUGGUAUGGUCCCCGAGCCGUCCUGUCAGAAUCCUAGUGGUGAUCAUUCAGGGUGGUUAUUCUUUGCUCGAUCAGGGUCCACACACGGCAGGUGUAAGCCAGGCUGCGGUGGAUGCUCGUAUCGGCUAUAGUAACUGCAGCCGACUGGAUGAGACCUCGUCACUCAUCUAUACGGAUUUCACACCCUCCUGCUCGGCCAAAAUCAAGAAGCCACGCUAUUGGUUCGAAGCUAACGAGAUUUGGUGUAGACCCCGGACCUACAAGUACUUGCCCCCAUAUUCUCUGUGGCAGGUAGUUACACGUGCGGACCGUGACCCAUCUUUUUAUUGGGAGUGUAGCCGGAUAUUCAGGCCAGGAGGAUCUAUUCAGCCCGCCCACUUUUUACGACUGGGAAGGAGGGGCCUCGCCCCACGAGGGCGAUGUGCAUACUCGUUCAACCCGCUCACCUCAGGAGCCCAACAGCUAGUGAAACGCUUGAUGAAACACUUUAUCAAGGUUACCGUAUCUCGAAUCCGCAUGGUGGUGGAAUGCGCCUGCGGAACCGACCAGCCCGCAAAUGCUGGGAAUUUGCUCUCGCCAGCUUCUCUUCUUAGGGUUUUAACUACGCCGGUGAGACAGCCAAGUCCUUUGUUGCCGAAGCUUUUCGGCCGCUUUAGAAGUGAAAAAAUGUGCGAGUUGCAAUGUUGCCGAUCUAGCCGACAGAAAUGGAAUUCGGGUAUCCCCGUCUUUAGCCCCAAUCGAAGGCAUCCGUCUCGCAUAAGUCAAACCAUGUUAGUCCAGAGACGACUCCGACUCACAUCUCAAAUAAUGGGUCGUACUAUUUCUUAUACAGCACUAACGGAGCGGAGUUACUUGUGGUGGCACAGCUCUCGUAGUAACUAUUGUCCGAACCUAUCCUCUCUACAUAGAUACCGUGCUAUAGAUCCCCACCCGAGAUGGACAGUACAUCCGGGUACCAACUCACUGAUCUUAAUCGCGUCCCCACCAACGGCGAUUAUAGAAUCAGAACCAACAGCAUUGACAUCACGGCCUAAGAUCUUGAGUCGGACUCAUCGGAUGACCACGUCUAUAAUUGUUAAAGUCGUAAAGACGCCAUCAUCUUUUGCAACAGGUGAUAGGUGUGCGCCCCUACAAUCUUCGGUCCUUAUCAGCGGGCCUUUAAGGGACAUGGUAGUAGCCAUCGGCGGCUCUGACAUUAAAAGCCUAUUGCUAGCUUUCAACUUAUCCGGUAUUGCGGUCAGGAGGUACACGUGGUCGGGUGGGAGAGUCCAUAAGUGUGAACGCGGCAAUAUUUAUAUUGGUAUCGAAUUCGACGCCCUGGUUGCAGCUCGAACAGCUUGCCUUCAGGGUGCGUUAGGUGGAAACUUACGAGGAACUACCGCAUUCGUGAUGCUUUCGGACAAGGCAAACUUAGUUAGAAGGAUCUCUUUGGCUAACCGCGUCCCGCGAUCGCAUGCUUUUCAUCGACAUUGGGUUUUACCGCCCGGAAAGAAUGUAUGGGCAAAUUACCUUGCCAGGUCUUGCAAGUUGCUGAACGAACAGAUUGAAGCUAUUACACCCGAGUCCUCAUCUAAUAGUCCCGCGUUGGGCACUGGUAUGUUGUCAUCUCGGUUGUGGUUCUUCAGGAAUUGGACGCCUAUAAACCGCCUCGUUGCCUACAAGGGUUUGCGGUGGACUCUAGUGGAUAGCUCGCCGUAUAUGCCUACCGCUGUGACAGCAUGGCGCACGGUAAUUAAGGGCAGUAGUAUUAGAUCCUUGGAGAGCCGGGAGCGUUUGAAAUGGACGACAGACAUCGCUACGGGUCUCCUGCUCACAACACCCCUCAGGGGCGACUCUUUGUGCCGUCUGAGGCCCAUCGUCAGAUCGCAAUGCGGGCUCAAGAAAACUCGCAUUCGAGCGCCCGAACGAGUUGUAGGCACUUCUUCAGUAAUGCGAAAAAGCUGGCAAGUAAAGGAGGGGAGCGCUCUUCGGCACGUCGCCCGUCGGGAGGCGGAGUUCUUCUCGGAGCGAUAUGAUAAGCUGCCUGCUAACUUCUCGGAUAUGCAUGGUGUAGAGCUAGGAUGCGAGAGUAUCUCGGAGGAUCGGCGGUUUCCUCUUACACCAAAUCACGGACCGGUCUGCCACUUCCAACAUGCCGGCGGGCAAAUACCGAAGUUGCCUAUUAUGUUAAAGACCCCCAGACUUGAACAGCUAACGAGGGGUGUCCGUGGUCCAUGUGCGUCCGCCUCAAGUGUCGCACUGGCACUGCACUUAUGUCUACCGGUACUCGCAUCUAAAUAUUUAAUAAGAAGCGUAAAUUCGGUGACAUCCUUAAGUGUGGCCCUGUUUGUGACUGUUGCCAGUGGAUCGUUGUCUCCUUUAUCAUACCGUGAAGGGCCCAUCCUUCGUGCAUCUGAUGUUCUAGUGAGCAUUCUAUGGAAUGCCAAUUCGUACGUUAUAGCGGCCGUGUGUUGUAAGUAUGGGCCGGAGCAUCUGUUCAUAUACCUCACAACGGGAGUUUGGGUGGUCAGAAGAGGGGAAAUAGGGCCGUCGUCGCUAGUCCACCGACGCUCUCCAUCGCUGGCGUACAGCAGUCCAGACAUCAUGUACGACGCCUCAACACUGCGGGAGGUUAUCCAGAUCGCGUUAAGCGGGUCCUUGGGGAAGUCCUAUGGAUCGGGGGGAGCCUUGAGGAUGACUACGACGCUUACUCCUUGGGACGAUACCGUACAGGCCUCCGAAACGGACUCGGAUGCCUGCGCACAACGGAAAACUUGUUAUGUCGAACGCAUUGUGUUAACAGAGCUAUAUUCUGAAAUAAACCCUUUUUCGUUCACCCGGGACAGAUAUAGCUGCCUUCAGUGGUUUGCCGGAGCAAUAUCCAAUUCGAUAAGACAUUUAGCAAUCAUCGGGGAUGUUCAUGUGCUUAAAAGUCAUUAUGCUCACAUGGGCAUGUCGCUGGCUCGGACUCUGAUCGAUUACGAGGCAGGCUACUUGUCAAUUAGUAGUUCGCUAGACUAUUACUGGGCGAGCGUUCGAGGUGGGUCAGCCAAUUUAUUAGAUUCGAUUUUACAUCCGGGAAUUUAUGACUCGCGGCGAGACAGGGAGGCCGCGAACUGUUACCUAGGGCGUGGGCGUUGGCCGGACGAUCGAUUCGCUAAAUUCUCACAGCGAGUCCGUCAGCGAGACGCGCAAGUUCCGACAGCGCAAGUGCCUGGAGGUUCAUCUUCCCUACCCAGACGUAUCCUGGGCCCUGUGGCUGUCACCAUAGGGAUCAGAACCCAGCUGUUUUGGUGCUCCGGACCUAAGCCUAUAUUGUUUAAGCACCGCACUAAACUACAGGCUAGUCAAGGGAUACAGGUAUUCCAUAGGAUCUUAAUACAACCUAACUCGCACAAUGGUCUGAAAGGCCUGCCUCCCGAUUCCGAAAGUAUCCUGUACUCCAUAAUUCCCAAUUCGGGAUCAGAGCCUAGUAAAAUGUGGUGCUGUCCUGUGCCUAUGCCAUCUAGAACCUGUAGUACUUUCAUUCCCUUCCAUGAUUCCGUCUACGGCCGCAGUUAUACGCGCGAGUACAGUAGUAAUCAUAACGGAGGAGGUCUCGUCGACGCUGUGGUGACAUCAUAG";
            //var output = p.TranslateProtein(input);
            //Debug.WriteLine("");
            //Debug.WriteLine(output);
            //Console.ReadLine();

            // assignment 13: peptide encoding problem
            //var input = "Peptide/p1.txt";
            //var output = p.PeptideEncoding(input);
            //Debug.WriteLine("");
            //foreach (var s in output)
            //{
            //    Debug.WriteLine(s);
            //}
            //Console.ReadLine();

            // assignment 14: cyclopeptide sequencing problem
            //var input = 32731;
            //var output = p.CountSubpeptides(input);
            //Debug.WriteLine("");
            //Debug.WriteLine(output);
            //Console.ReadLine();

            // assignment 15: Generating Theoretical Spectrum Problem
            //var input = "ATLAQWFFWPHYCM";
            //var output = p.CyclicSpectrumGeneration(input);
            //Debug.WriteLine("");
            //foreach (var s in output)
            //{
            //    Debug.Write(s + " ");
            //}
            //Debug.WriteLine("");
            //Console.ReadLine();

            // assignment 16: Cyclopeptide Sequencing
            //var input = "0 87 114 114 115 128 137 137 156 156 156 202 215 229 251 265 270 270 274 312 312 316 330 352 385 388 402 407 426 426 444 467 468 472 489 516 541 544 563 581 582 582 600 603 604 628 672 696 697 700 718 718 719 737 756 759 784 811 828 832 833 856 874 874 893 898 912 915 948 970 984 988 988 1026 1030 1030 1035 1049 1071 1085 1098 1144 1144 1144 1163 1163 1172 1185 1186 1186 1213 1300";
            //var output = p.CyclopeptideSequencing(input);
            //Debug.WriteLine("");
            //foreach (var s in output)
            //{
            //    Debug.WriteLine(string.Join("-", s.Select(x => x.ToString())));
            //}
            //Debug.WriteLine("");
            //Console.ReadLine();

            // quizzes
            // q2
            //var input = "CCCAGGACUGAGAUCAAU";
            //var output = p.TranslateProtein(input);
            //Debug.WriteLine("");
            //Debug.WriteLine(output);
            //var output2 = p.TranslateReverseProtein(input);
            //Debug.WriteLine("");
            //Debug.WriteLine(output2);
            //Console.ReadLine();

            // q5
            //var input = "MAIT";
            //var output = p.CyclicSpectrumGeneration(input);
            //Debug.WriteLine("");
            //foreach (var s in output)
            //{
            //    Debug.Write(s + " ");
            //}
            //Debug.WriteLine("");
            //Console.ReadLine();

            // q6
            //var spectrum = new List<int> { 0, 71, 99, 101, 103, 128, 129, 199, 200, 204, 227, 230, 231, 298, 303, 328, 330, 332, 333 };
            //var input = "AQV";
            //var output = p.LinearSpectrumGeneration(input);
            //Debug.WriteLine("");
            //Debug.WriteLine(p.IsPeptideConsistentWithSpectrum(output, spectrum));
            //foreach (var s in output)
            //{
            //    Debug.Write(s + " ");
            //}
            //Debug.WriteLine("");
            //Console.ReadLine();

            // assignment 17: cyclopeptide scoring
            //var input = "Peptide/p2.txt";
            //var output = p.CyclopeptideScoringProblem(input);
            //Debug.WriteLine("");            
            //Debug.WriteLine(output);            
            //Console.ReadLine();

            // charging station: trimming peptide leaderboard
            //var input = "Peptide/p3.txt";
            //var output = p.LinearPeptideScoringProblem(input);
            //Debug.WriteLine("");
            //Debug.WriteLine(output);
            //Console.ReadLine();

            //var input = "Peptide/p4.txt";
            //var output = p.TrimPeptideLeaderboard(input);
            //Debug.WriteLine("");
            //foreach(var s in output)
            //{
            //    Debug.WriteLine(s);
            //}
            //Console.ReadLine();

            // assignment 18: LeaderboardCyclopeptideSequencing
            //var input = "Peptide/p5.txt";
            //var output = p.LeaderboardCyclopeptideSequencing(input);
            //Debug.WriteLine("");
            //Debug.WriteLine(string.Join("-", output.Select(x => x.ToString())));            
            //Console.ReadLine();

            // assignment 19: SpectralConvolutionProblem
            //var input = "101 765 400 588 137 616 594 229 246 863 652 131 265 457 113 881 879 406 0 359 866 378 744 707 780 994 250 402 748 766 287 329 838 515 269 156 228 881 537 128 479 729 214 115 366 113 665 635 592 479 893 515 628 534 857 725 342 460";
            //var output = p.SpectralConvolutionProblem(input);
            //Debug.WriteLine("");
            //Debug.WriteLine(string.Join(" ", output.Select(x => x.ToString())));
            //Console.ReadLine();

            // assignment 20: ConvolutionCyclopeptideSequencing
            //var input = "Peptide/p6.txt";
            //var output = p.ConvolutionCyclopeptideSequencing(input);
            //Debug.WriteLine("");
            //Debug.WriteLine(string.Join("-", output.Select(x => x.ToString())));
            //Console.ReadLine();

            // quizzes
            // q3
            //var peptide = "MAMA";
            //var spectrum = new List<int>() { 0, 71, 98, 99, 131, 202, 202, 202, 202, 202, 299, 333, 333, 333, 503 };
            //var score = p.CyclopeptideScoringProblemLogic(peptide, spectrum);

            // q4
            //var lpeptide = "PEEP";
            //var lspectrum = new List<int>() { 0, 97, 129, 129, 129, 194, 226, 323, 323, 355, 452 };
            //var lscore = p.LinearPeptideScoringProblemLogic(lpeptide, lspectrum);

            // q5
            //var spectrum = new List<int>() { 0, 86, 160, 234, 308, 320, 382 };
            //var convolution = p.SpectralConvolutionProblemLogic(spectrum);
        }

        public List<int> ConvolutionCyclopeptideSequencing(string inputFile)
        {
            var m = 0;
            var n = 0;
            var espectrum = new List<int>();
            
            var fileLines = File.ReadAllLines(inputFile);

            for(int i = 0; i < fileLines.Length; i++)
            {
                if (i == 0)
                {
                    m = Convert.ToInt32(fileLines[i]);
                }
                if (i == 1)
                {
                    n = Convert.ToInt32(fileLines[i]);
                }
                if (i == 2)
                {
                    espectrum = new List<int>(fileLines[i].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).OrderBy(x => x));
                }
            }

            return ConvolutionCyclopeptideSequencingLogic(m, n, espectrum);
        }

        public List<List<int>> ExpandPeptidesWithConvolutedSpectrum(List<List<int>> currentPeptides, List<int> topMConvolutedSpectrum)
        {
            var expanded = new List<List<int>>();
            foreach (var peptide in currentPeptides)
            {
                foreach (var mass in topMConvolutedSpectrum)
                {
                    var newPeptide = new List<int>();
                    newPeptide.AddRange(peptide);
                    newPeptide.Add(mass);
                    expanded.Add(newPeptide);
                }
            }

            return expanded;
        }

        public List<int> ConvolutionCyclopeptideSequencingLogic(int m, int n, List<int> experimentalSpectrum)
        {
            var convolution = SpectralConvolutionProblemLogic(experimentalSpectrum);

            // remove those <57 and >200
            convolution = convolution.Where(x => x >= 57 && x <= 200).ToList();

            var trimmedConvolution = TrimConvolutedSpectrum(convolution, m);

            var peptides = new List<List<int>>();
            peptides.Add(new List<int>());
            var leaderPeptide = new List<int>();
            
            var holderPeptides = new List<List<int>>();

            while (peptides.Count > 0)
            {
                peptides = ExpandPeptidesWithConvolutedSpectrum(peptides, trimmedConvolution);
                var removedPeptides = new List<List<int>>();
                for (int i = 0; i < peptides.Count; i++)
                {
                    var peptide = peptides[i];
                    var currentPeptideInString = ConvertPeptideIntegerFormToStringForm(peptide);
                    var cycloSpectrumOfCurrentPeptide = CyclicSpectrumGeneration(currentPeptideInString);
                    var linearSpectrumOfCurrentPeptide = LinearSpectrumGeneration(currentPeptideInString);
                    var currentMass = GetPeptideMass(peptide);
                    var parentMass = GetParentMass(experimentalSpectrum);
                    if (currentMass == parentMass)
                    {
                        var peptideScore = LinearPeptideScoringProblemLogic(currentPeptideInString, experimentalSpectrum);
                        var currentLeaderPeptideInString = ConvertPeptideIntegerFormToStringForm(leaderPeptide);
                        var leaderPeptideScore = LinearPeptideScoringProblemLogic(currentLeaderPeptideInString, experimentalSpectrum);
                        if (peptideScore > leaderPeptideScore)
                        {
                            leaderPeptide = peptide;
                        }
                    }
                    else if (currentMass > parentMass)
                    {
                        removedPeptides.Add(peptide);
                    }
                }
                foreach (var removedPeptide in removedPeptides)
                {
                    peptides.Remove(removedPeptide);
                }
                peptides = TrimPeptideLeaderboardLogic(peptides, experimentalSpectrum, n);
            }
            return leaderPeptide;            
        }

        public List<int> TrimConvolutedSpectrum(List<int> candidates, int m)
        {
            var scores = new Dictionary<int, int>();
            foreach (var p in candidates)
            {
                if (!scores.ContainsKey(p))
                {
                    scores.Add(p, candidates.Where(x => x == p).Count());
                }
            }

            scores.OrderByDescending(x => x.Value);

            var minScore = scores.Select(x => x.Value).OrderByDescending(x => x).Skip(m - 1).Take(1).FirstOrDefault();

            var trimmed = scores.Where(x => x.Value >= minScore).ToList().OrderBy(x => x.Key);
            var trimmedSpectrum = trimmed.Select(x => x.Key).ToList();

            return trimmedSpectrum;
        }

        public List<int> SpectralConvolutionProblemLogic(List<int> input)
        {
            input.Sort();
            var convolution = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    var diff = input[i] - input[j];
                    if (diff > 0)
                    {
                        convolution.Add(diff);
                    }
                }
            }
            convolution.Sort();
            return convolution;

        }

        public List<int> SpectralConvolutionProblem(string input)
        {
            var spectra = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToList();
            spectra.Sort();

            return SpectralConvolutionProblemLogic(spectra);
        }

        public List<int> LeaderboardCyclopeptideSequencing(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);

            var topNScoringPeptide = 0;
            var spectrum = new List<int>();

            for (int i = 0; i < fileLines.Length; i++)
            {
                if (i == 0)
                {
                    topNScoringPeptide = Convert.ToInt32(fileLines[i]);
                }
                if (i == 1)
                {
                    spectrum = new List<int>(fileLines[i].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).OrderBy(x => x));
                }
            }

            return LeaderboardCyclopeptideSequencingLogic(topNScoringPeptide, spectrum);
        }

        public List<int> LeaderboardCyclopeptideSequencingLogic(int topNScoringPeptide, List<int> spectrum)
        {
            var peptides = new List<List<int>>();
            peptides.Add(new List<int>());

            var leaderPeptide = new List<int>();

            var holderPeptides = new List<List<int>>();
            while (peptides.Count > 0)
            {
                peptides = ExpandPeptides(peptides);
                var removedPeptides = new List<List<int>>();
                for (int i = 0; i < peptides.Count; i++)
                {
                    var peptide = peptides[i];
                    var currentPeptideInString = ConvertPeptideIntegerFormToStringForm(peptide);
                    var cycloSpectrumOfCurrentPeptide = CyclicSpectrumGeneration(currentPeptideInString);
                    var linearSpectrumOfCurrentPeptide = LinearSpectrumGeneration(currentPeptideInString);
                    var currentMass = GetPeptideMass(peptide);
                    var parentMass = GetParentMass(spectrum);
                    if (currentMass == parentMass)
                    {
                        var peptideScore = LinearPeptideScoringProblemLogic(currentPeptideInString, spectrum);
                        var currentLeaderPeptideInString = ConvertPeptideIntegerFormToStringForm(leaderPeptide);
                        var leaderPeptideScore = LinearPeptideScoringProblemLogic(currentLeaderPeptideInString, spectrum);
                        if (peptideScore > leaderPeptideScore)
                        {
                            leaderPeptide = peptide;
                        }
                    }
                    else if (currentMass > parentMass)
                    {
                        removedPeptides.Add(peptide);
                    }
                }
                foreach (var removedPeptide in removedPeptides)
                {
                    peptides.Remove(removedPeptide);
                }
                peptides = TrimPeptideLeaderboardLogic(peptides, spectrum, topNScoringPeptide);
            }
            return leaderPeptide;
        }
        
        public List<string> TrimPeptideLeaderboard(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);

            var peptides = new List<string>();
            var spectrum = new List<int>();
            var topNScoringPeptide = 0;

            for (int i = 0; i < fileLines.Length; i++)
            {
                if (i == 0)
                {
                    peptides = fileLines[i].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                if (i == 1)
                {
                    spectrum = new List<int>(fileLines[i].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).OrderBy(x => x));
                }
                if (i == 2)
                {
                    topNScoringPeptide = Convert.ToInt32(fileLines[i]);
                }
            }

            return TrimPeptideLeaderboardLogic(peptides, spectrum, topNScoringPeptide);
        }

        public List<List<int>> TrimPeptideLeaderboardLogic(List<List<int>> peptides, List<int> spectrum, int topNScoringPeptide)
        {
            // first get all scores
            var scores = new List<PeptideLeaderboardObject>();
            foreach (var p in peptides)
            {
                var pstring = ConvertPeptideIntegerFormToStringForm(p);
                var score = LinearPeptideScoringProblemLogic(pstring, spectrum);
                scores.Add(new PeptideLeaderboardObject { Peptide = pstring, Score = score });
            }

            // get top N scores
            var minScore = scores.Select(x => x.Score).OrderByDescending(x => x).Skip(topNScoringPeptide - 1).Take(1).FirstOrDefault();

            // return all leaderboard object with minscore and higher
            var trimmed = scores.Where(x => x.Score >= minScore).ToList().OrderByDescending(x => x.Score);
            var trimmedPeptides = trimmed.Select(x => x.Peptide).ToList();

            return trimmedPeptides.Select(x => ConvertPeptideStringFormToIntegerForm(x)).ToList();
        }

        public List<string> TrimPeptideLeaderboardLogic(List<string> peptides, List<int> spectrum, int topNScoringPeptide)
        {
            // first get all scores
            var scores = new List<PeptideLeaderboardObject>();
            foreach(var p in peptides)
            {
                var score = LinearPeptideScoringProblemLogic(p, spectrum);
                scores.Add(new PeptideLeaderboardObject { Peptide = p, Score = score });
            }

            // get top N scores
            var minScore = scores.Select(x => x.Score).OrderByDescending(x => x).Skip(topNScoringPeptide - 1).Take(1).FirstOrDefault();

            // return all leaderboard object with minscore and higher
            var trimmed = scores.Where(x => x.Score >= minScore).ToList().OrderByDescending(x => x.Score);
            var trimmedPeptides = trimmed.Select(x => x.Peptide).ToList();

            return trimmedPeptides;
        }

        public class PeptideLeaderboardObject : IComparable<PeptideLeaderboardObject>
        {
            public string Peptide { get; set; }
            public int Score { get; set; }

            public int CompareTo(PeptideLeaderboardObject other)
            {
                return this.Score.CompareTo(other.Score);
            }
        }

        public int LinearPeptideScoringProblem(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);

            var peptide = "";
            var spectrum = new List<int>();

            for (int i = 0; i < fileLines.Length; i++)
            {
                if (i == 0)
                {
                    peptide = fileLines[i];
                }
                if (i == 1)
                {
                    spectrum = new List<int>(fileLines[i].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).OrderBy(x => x));
                }
            }

            return LinearPeptideScoringProblemLogic(peptide, spectrum);
        }

        public int LinearPeptideScoringProblemLogic(string peptide, List<int> spectrum)
        {
            var theoretical = LinearSpectrumGeneration(peptide);
            var testList = new HashSet<int>();

            var groups = spectrum.GroupBy(x => x).Select(x => new { x.Key, Count = x.Count() }).ToList();

            var count = 0;
            foreach (var pspectrum in spectrum)
            {
                if (theoretical.Contains(pspectrum) && !testList.Contains(pspectrum))
                {
                    var tcount = theoretical.Where(x => x == pspectrum).Count();
                    var scount = spectrum.Where(x => x == pspectrum).Count();
                    count += Math.Min(tcount, scount);                    
                    testList.Add(pspectrum);
                }
            }

            return count;
        }

        public int CyclopeptideScoringProblem(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);

            var peptide = "";
            var spectrum = new List<int>();

            for(int i = 0; i < fileLines.Length; i++)
            {
                if (i == 0)
                {
                    peptide = fileLines[i];
                }
                if (i == 1)
                {
                    spectrum = new List<int>(fileLines[i].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).OrderBy(x => x));
                }
            }

            return CyclopeptideScoringProblemLogic(peptide, spectrum);
        }

        public int CyclopeptideScoringProblemLogic(string peptide, List<int> spectrum)
        {
            var theoretical = CyclicSpectrumGeneration(peptide);
            var testList = new HashSet<int>();

            var groups = spectrum.GroupBy(x => x).Select(x => new { x.Key, Count = x.Count() }).ToList();

            var count = 0;
            foreach(var pspectrum in spectrum)
            {
                if (theoretical.Contains(pspectrum) && !testList.Contains(pspectrum))
                {
                    if (spectrum.Where(x => x == pspectrum).Count() == 1)
                    {
                        count++;
                    }
                    else
                    {
                        var tcount = theoretical.Where(x => x == pspectrum).Count();
                        var scount = spectrum.Where(x => x == pspectrum).Count();
                        count += Math.Min(tcount, scount);
                    }
                    testList.Add(pspectrum);
                }
            }

            return count;
        }

        // end of week 3

        public List<List<int>> CyclopeptideSequencing(string input)
        {
            var inputInt = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToList();

            return CyclopeptideSequencingLogic(inputInt);
        }

        public List<List<int>> CyclopeptideSequencingLogic(List<int> spectrum)
        {
            var peptides = new List<List<int>>();
            peptides.Add(new List<int>());

            var holderPeptides = new List<List<int>>();
            
            while(peptides.Count > 0)
            {
                peptides = ExpandPeptides(peptides);
                //var loopPeptides = new List<List<int>>(peptides);
                var removedPeptides = new List<List<int>>();
                for(int i = 0; i < peptides.Count; i++)
                {
                    var peptide = peptides[i];
                    var currentPeptideInString = ConvertPeptideIntegerFormToStringForm(peptide);
                    var cycloSpectrumOfCurrentPeptide = CyclicSpectrumGeneration(currentPeptideInString);
                    var linearSpectrumOfCurrentPeptide = LinearSpectrumGeneration(currentPeptideInString);
                    var currentMass = GetPeptideMass(peptide);
                    if (currentMass == GetParentMass(spectrum))
                    {
                        if (cycloSpectrumOfCurrentPeptide.SequenceEqual(spectrum) && cycloSpectrumOfCurrentPeptide.Count == spectrum.Count)
                        {
                            holderPeptides.Add(peptide);
                        }
                        removedPeptides.Add(peptide);
                    }
                    else if (!IsPeptideConsistentWithSpectrum(linearSpectrumOfCurrentPeptide, spectrum))
                    {
                        removedPeptides.Add(peptide);
                    }
                }
                foreach(var removedPeptide in removedPeptides)
                {
                    peptides.Remove(removedPeptide);
                }
            }

            var dedup = holderPeptides.Distinct(new PeptideListEqualityComparer()).ToList();
            
            return dedup;
        }

        public class PeptideListEqualityComparer : IEqualityComparer<List<int>>
        {
            public bool Equals(List<int> x, List<int> y)
            {
                return x.SequenceEqual(y);
            }

            public int GetHashCode(List<int> obj)
            {
                var asString = string.Join(",", obj.Select(x => x.ToString()));
                return asString.GetHashCode();
            }
        }

        public bool IsPeptideConsistentWithSpectrum(List<int> peptideCyclomaticSpectrum, List<int> spectrum)
        {
            return peptideCyclomaticSpectrum.Except(spectrum).Count() == 0;
        }

        public string ConvertPeptideIntegerFormToStringForm(List<int> peptide)
        {
            var sb = new StringBuilder();
            foreach(var mass in peptide)
            {
                sb.Append(AminoAcidMass.FirstOrDefault(x => x.Value == mass).Key);
            }
            return sb.ToString();
        }

        public List<int> ConvertPeptideStringFormToIntegerForm(string peptide)
        {
            var p = new List<int>();
            foreach(var s in peptide)
            {
                p.Add(AminoAcidMass.FirstOrDefault(x => x.Key == s.ToString()).Value);
            }
            return p;
        }

        public List<List<int>> ExpandPeptides(List<List<int>> currentPeptides)
        {
            var expanded = new List<List<int>>();
            foreach (var peptide in currentPeptides)
            {
                foreach (var aminoAcidKvp in AminoAcidMass)
                {
                    var newPeptide = new List<int>();
                    newPeptide.AddRange(peptide);
                    newPeptide.Add(aminoAcidKvp.Value);
                    expanded.Add(newPeptide);
                }
            }

            return expanded;
        }

        public int GetPeptideMass(List<int> peptide)
        {
            return peptide.Sum();
        }

        public int GetParentMass(List<int> spectrum)
        {
            return spectrum.Max();
        }

        public List<int> CyclicSpectrumGeneration(string peptide)
        {
            var prefixMass = new SortedDictionary<int, int>();
            prefixMass.Add(0, 0);

            for (int i = 0; i < peptide.Length; i++)
            {
                prefixMass.Add(i + 1, prefixMass[i] + AminoAcidMass[peptide.Substring(i, 1)]);
            }

            var peptideMass = prefixMass[peptide.Length];

            var cyclicSpectrum = new List<int>();
            cyclicSpectrum.Add(0);
            for (int i = 0; i < peptide.Length; i++)
            {
                for (int j = i + 1; j <= peptide.Length; j++)
                {
                    cyclicSpectrum.Add(prefixMass[j] - prefixMass[i]);
                    if (i > 0 && j < peptide.Length)
                    {
                        cyclicSpectrum.Add(peptideMass - (prefixMass[j] - prefixMass[i]));
                    }
                }
            }

            cyclicSpectrum.Sort();

            return cyclicSpectrum;
        }

        public List<int> LinearSpectrumGeneration(string peptide)
        {
            var prefixMass = new SortedDictionary<int, int>();
            prefixMass.Add(0, 0);

            for(int i = 0; i < peptide.Length; i++)
            {
                prefixMass.Add(i + 1, prefixMass[i] + AminoAcidMass[peptide.Substring(i, 1)]);
            }

            var linearSpectrum = new List<int>();
            linearSpectrum.Add(0);
            for(int i = 0; i < peptide.Length; i++)
            {
                for(int j = i + 1; j <= peptide.Length; j++)
                {
                    linearSpectrum.Add(prefixMass[j] - prefixMass[i]);
                }
            }

            linearSpectrum.Sort();

            return linearSpectrum;
        }

        public int CountSubpeptides(int input)
        {
            return input * (input - 1);
        }

        public int Combinatorial(int total, int choose)
        {
            if (choose > total) return 0;
            return Factorial(total) / (Factorial(choose) * Factorial(total - choose));
        }

        public int Factorial(int i)
        {
            if (i <= 1) return 1;
            return i * Factorial(i - 1);
        }

        public List<string> PeptideEncoding(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var lines = new List<string>();

            string dna = "";
            string peptide = "";

            for(int i = 0; i < fileLines.Count(); i++)
            {
                if (i == 0)
                {
                    dna = fileLines[i];
                }
                else if (i == 1)
                {
                    peptide = fileLines[i];
                }
            }

            return PeptideEncodingLogic(dna, peptide);
        }

        public List<string> PeptideEncodingLogic(string dna, string peptide)
        {
            // 3 reading frames, then reverse complement            
            var peptideLength = peptide.Length;

            var reverseDna = ReverseComplement(dna);
            var rna = TranslateDNA(dna);
            var reverseRna = TranslateDNA(reverseDna);

            var outputList = new List<string>();

            var forwardPeptide = new Dictionary<int, string>();
            forwardPeptide.Add(0, "");
            forwardPeptide.Add(1, "");
            forwardPeptide.Add(2, "");
            for (int i = 0; i < dna.Length - CodonLength; i += 3)
            {
                // first reading frame
                var currentCodon = rna.Substring(i, CodonLength);
                var firstFramePeptide = forwardPeptide[0];
                var firstTranslatedProtein = TranslateProtein(currentCodon);
                firstFramePeptide = firstFramePeptide + firstTranslatedProtein;
                if (firstFramePeptide.Length >= peptideLength && !string.IsNullOrEmpty(firstTranslatedProtein) &&
                    firstFramePeptide.Substring(firstFramePeptide.Length - peptideLength, peptideLength) == peptide)
                {
                    // add the current codon, plus previous codon RNA, then translate
                    var previousCodonDnas = rna.Substring(i - ((peptideLength-1)*CodonLength), (peptideLength * CodonLength));
                    outputList.Add(ReverseTranslateRNA(previousCodonDnas));
                }
                forwardPeptide[0] = firstFramePeptide;

                // second reading frame
                if (i + 1 + CodonLength < dna.Length)
                {
                    var j = i + 1;
                    var secondReadingFrameCurrentCodon = rna.Substring(j, CodonLength);
                    var secondFramePeptide = forwardPeptide[1];
                    var secondTranslatedProtein = TranslateProtein(secondReadingFrameCurrentCodon);
                    secondFramePeptide = secondFramePeptide + secondTranslatedProtein;
                    if (secondFramePeptide.Length > peptideLength && !string.IsNullOrEmpty(secondTranslatedProtein) &&
                        secondFramePeptide.Substring(secondFramePeptide.Length - peptideLength, peptideLength) == peptide)
                    {
                        // add the current codon, plus previous codon RNA, then translate
                        var secondFramePreviousCodonDnas = rna.Substring(j - ((peptideLength - 1) * CodonLength), (peptideLength * CodonLength));
                        outputList.Add(ReverseTranslateRNA(secondFramePreviousCodonDnas));
                    }
                    forwardPeptide[1] = secondFramePeptide;
                }

                // third reading frame
                if (i + 2 + CodonLength < dna.Length)
                {
                    var k = i + 2;
                    var thirdReadingFrameCurrentCodon = rna.Substring(k, CodonLength);
                    var thirdFramePeptide = forwardPeptide[2];
                    var thirdTranslatedProtein = TranslateProtein(thirdReadingFrameCurrentCodon);
                    thirdFramePeptide = thirdFramePeptide + thirdTranslatedProtein;
                    if (thirdFramePeptide.Length >= peptideLength && !string.IsNullOrEmpty(thirdTranslatedProtein) &&
                        thirdFramePeptide.Substring(thirdFramePeptide.Length - peptideLength, peptideLength) == peptide)
                    {
                        // add the current codon, plus previous codon RNA, then translate
                        var thirdFramePreviousCodonDnas = rna.Substring(k - ((peptideLength - 1) * CodonLength), (peptideLength * CodonLength));
                        outputList.Add(ReverseTranslateRNA(thirdFramePreviousCodonDnas));
                    }
                    forwardPeptide[2] = thirdFramePeptide;
                }
            }

            // reverse
            var reversePeptide = new Dictionary<int, string>();
            reversePeptide.Add(0, "");
            reversePeptide.Add(1, "");
            reversePeptide.Add(2, "");
            for (int i = 0; i < reverseDna.Length - CodonLength; i += 3)
            {
                // first reading frame
                var currentCodon = reverseRna.Substring(i, CodonLength);
                var firstFramePeptide = reversePeptide[0];
                var firstTranslatedProtein = TranslateProtein(currentCodon);
                firstFramePeptide = firstFramePeptide + firstTranslatedProtein;
                if (firstFramePeptide.Length >= peptideLength && !string.IsNullOrEmpty(firstTranslatedProtein) &&
                    firstFramePeptide.Substring(firstFramePeptide.Length - peptideLength, peptideLength) == peptide)
                {
                    // add the current codon, plus previous codon RNA, then translate
                    var previousCodonDnas = reverseRna.Substring(i - ((peptideLength - 1) * CodonLength), (peptideLength * CodonLength));
                    outputList.Add(ReverseComplement(ReverseTranslateRNA(previousCodonDnas)));
                }
                reversePeptide[0] = firstFramePeptide;

                // second reading frame
                if (i + 1 + CodonLength < reverseDna.Length)
                {
                    var j = i + 1;
                    var secondReadingFrameCurrentCodon = reverseRna.Substring(j, CodonLength);
                    var secondFramePeptide = reversePeptide[1];
                    var secondTranslatedProtein = TranslateProtein(secondReadingFrameCurrentCodon);
                    secondFramePeptide = secondFramePeptide + secondTranslatedProtein;
                    if (secondFramePeptide.Length > peptideLength && !string.IsNullOrEmpty(secondTranslatedProtein) &&
                        secondFramePeptide.Substring(secondFramePeptide.Length - peptideLength, peptideLength) == peptide)
                    {
                        // add the current codon, plus previous codon RNA, then translate
                        var secondFramePreviousCodonDnas = reverseRna.Substring(j - ((peptideLength - 1) * CodonLength), (peptideLength * CodonLength));
                        outputList.Add(ReverseComplement(ReverseTranslateRNA(secondFramePreviousCodonDnas)));
                    }
                    reversePeptide[1] = secondFramePeptide;
                }

                // third reading frame
                if (i + 2 + CodonLength < reverseDna.Length)
                {
                    var k = i + 2;
                    var thirdReadingFrameCurrentCodon = reverseRna.Substring(k, CodonLength);
                    var thirdFramePeptide = reversePeptide[2];
                    var thirdTranslatedProtein = TranslateProtein(thirdReadingFrameCurrentCodon);
                    thirdFramePeptide = thirdFramePeptide + thirdTranslatedProtein;
                    if (thirdFramePeptide.Length >= peptideLength && !string.IsNullOrEmpty(thirdTranslatedProtein) &&
                        thirdFramePeptide.Substring(thirdFramePeptide.Length - peptideLength, peptideLength) == peptide)
                    {
                        // add the current codon, plus previous codon RNA, then translate
                        var thirdFramePreviousCodonDnas = reverseRna.Substring(k - ((peptideLength - 1) * CodonLength), (peptideLength * CodonLength));
                        outputList.Add(ReverseComplement(ReverseTranslateRNA(thirdFramePreviousCodonDnas)));
                    }
                    reversePeptide[2] = thirdFramePeptide;
                }
            }

            return outputList;
        }

        public string TranslateDNA(string dna)
        {
            return dna.Replace("T", "U");
        }

        public string ReverseTranslateRNA(string rna)
        {
            return rna.Replace("U", "T");
        }

        public string TranslateProtein(string input)
        {
            var sb = new StringBuilder();
            
            while(input.Length >= CodonLength)
            {
                var currentProtein = input.Substring(0, CodonLength);
                sb.Append(CodonTable[currentProtein]);
                input = input.Substring(CodonLength);
            }

            return sb.ToString();
        }

        public string TranslateReverseProtein(string input)
        {
            var reversed = TranslateDNA(ReverseComplement(ReverseTranslateRNA(input)));

            return TranslateProtein(reversed);
        }

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

        // second week ends

        public List<string> ContigGenerationFromPatterns(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var lines = new List<string>();

            for (int i = 0; i < fileLines.Count(); i++)
            {
                var t = fileLines[i];
                if (!string.IsNullOrEmpty(t))
                {
                    lines.Add(t.Trim());
                }
            }
            
            var debruijnAdjacencyObject = CreateDeBruijnGraphFromPatternsLogic(lines);
            
            var eulerianNodes = GetEulerianNodesFromDebruijnAdjacency(debruijnAdjacencyObject);            
            var eulerianEdges = GetEulerianEdgesFromDebruijnAdjacency(debruijnAdjacencyObject);

            var result = MaximalNonBranchingPathsLogic(eulerianNodes, eulerianEdges);

            var res = new List<string>();
            foreach(var r in result)
            {
                res.Add(GenomePathStringReconstructionLogic(r.Select(x => x.Label).ToList()));
            }

            return res;
        }        

        public List<string> MaximalNonBranchingPaths(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var lines = new List<string>();

            var allNodes = new HashSet<EulerianNode>();
            var allEdges = new HashSet<EulerianEdge>();

            foreach (var l in fileLines)
            {
                if (!string.IsNullOrEmpty(l))
                {
                    // split by ->
                    var split = l.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                    // first one is always one
                    var firstNodeLabel = split[0].Trim();

                    EulerianNode fromNode = null;
                    if (!allNodes.Any(n => n.Label == firstNodeLabel))
                    {
                        fromNode = new EulerianNode(firstNodeLabel);
                        allNodes.Add(fromNode);
                    }
                    else
                    {
                        fromNode = allNodes.Where(n => n.Label == firstNodeLabel).FirstOrDefault();
                    }

                    // second one needs to be split by "," again
                    var secondSplit = split[1].Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    var adjacentLabels = secondSplit.Select(x => x.Trim()).ToList();
                    foreach (var al in adjacentLabels)
                    {
                        if (!fromNode.OutgoingLabel.Contains(al))
                        {
                            fromNode.OutgoingLabel.Add(al);
                        }

                        EulerianNode toNode = null;

                        if (!allNodes.Any(n => n.Label == al))
                        {
                            toNode = new EulerianNode(al);
                            allNodes.Add(toNode);
                        }
                        else
                        {
                            toNode = allNodes.Where(n => n.Label == al).FirstOrDefault();
                        }

                        if (!toNode.IncomingLabel.Contains(firstNodeLabel))
                        {
                            toNode.IncomingLabel.Add(firstNodeLabel);
                        }

                        var newEdge = new EulerianEdge(fromNode, toNode);
                        if (!allEdges.Contains(newEdge))
                        {
                            allEdges.Add(newEdge);
                        }
                    }
                }
            }

            var combinedEdges = new Dictionary<string, List<EulerianEdge>>();
            foreach (var e in allEdges)
            {
                if (combinedEdges.ContainsKey(e.From.Label))
                {
                    var existing = combinedEdges[e.From.Label];
                    existing.Add(e);
                }
                else
                {
                    var newList = new List<EulerianEdge> { e };
                    combinedEdges.Add(e.From.Label, newList);
                }
            }

            return MaximalNonBranchingPathsLogic(allNodes, combinedEdges).Select(x => string.Join(" -> ", x.Select(y => y.Label))).ToList();
        }

        public List<List<EulerianNode>> MaximalNonBranchingPathsLogic(HashSet<EulerianNode> nodes, Dictionary<string, List<EulerianEdge>> edges)
        {
            var paths = new List<List<EulerianNode>>();

            var connectedNodes = new HashSet<EulerianNode>();
            
            // normal
            foreach(var n in nodes)
            {
                if (n.IncomingLabel.Count == 1 && n.OutgoingLabel.Count == 1)
                {
                    continue;
                }
                else
                {
                    if (n.OutgoingLabel.Count > 0)
                    {
                        connectedNodes.Add(n);
                        foreach (var e in edges[n.Label])
                        {
                            var wLabel = e.To.Label;
                            var w = nodes.Where(a => a.Label == wLabel).FirstOrDefault();
                            var nbp = new List<EulerianNode>();
                            nbp.Add(n);
                            nbp.Add(w);                            
                            connectedNodes.Add(w);
                            while (w.IncomingLabel.Count == 1 && w.OutgoingLabel.Count == 1)
                            {
                                foreach(var e2 in edges[w.Label])
                                {                                    
                                    var uLabel = e2.To.Label;
                                    var u = nodes.Where(a => a.Label == uLabel).FirstOrDefault();
                                    nbp.Add(u);
                                    connectedNodes.Add(u);
                                    w = u;
                                }
                            }
                            paths.Add(nbp);
                        }
                    }
                }
            }

            // isolated
            foreach(var n in nodes)
            {
                if (connectedNodes.Any(x => x.Label == n.Label))
                {
                    continue;
                }
                else
                {
                    if (n.OutgoingLabel.Count > 0)
                    {
                        connectedNodes.Add(n);
                        foreach (var e in edges[n.Label])
                        {
                            var wLabel = e.To.Label;
                            var w = nodes.Where(a => a.Label == wLabel).FirstOrDefault();
                            var nbp = new List<EulerianNode>();
                            nbp.Add(n);
                            nbp.Add(w);
                            connectedNodes.Add(w);
                            while (w.IncomingLabel.Count == 1 && w.OutgoingLabel.Count == 1 && w.Label != n.Label)
                            {
                                foreach (var e2 in edges[w.Label])
                                {
                                    var uLabel = e2.To.Label;
                                    var u = nodes.Where(a => a.Label == uLabel).FirstOrDefault();
                                    nbp.Add(u);
                                    connectedNodes.Add(u);
                                    w = u;
                                }
                            }
                            paths.Add(nbp);
                        }
                    }
                }
            }

            return paths;
        }

        public string StringReconstructionFromReadPairs(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var k = 0;
            var d = 0;

            var nodesList = new List<PairedEulerianNode>();
            for (int i = 0; i < fileLines.Length; i++)
            {
                if (i == 0)
                {
                    var ints = fileLines[i].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    k = Convert.ToInt32(ints[0]);
                    d = Convert.ToInt32(ints[1]);
                }
                else
                {
                    var patterns = fileLines[i].Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                    var firstPattern = patterns[0];
                    var terminalPattern = patterns[1];

                    var newNode = new PairedEulerianNode(firstPattern, terminalPattern);

                    nodesList.Add(newNode);
                }
            }

            return StringReconstructionFromReadPairsLogic(nodesList, k, d);
        }

        public string StringReconstructionFromReadPairsLogic(List<PairedEulerianNode> patterns, int k, int d)
        {
            // first construct the graph
            var graph = CreatePairedDebruijnFromReadPairs(patterns);

            var currentCycle = ConstructEulerianPathFromAdjacenciesLogic2(graph.Key, graph.Value);

            var convert = ConvertUnifiedPairEulerianNodeToPairedEulerianNode(currentCycle);

            var result = StringSpelledByGappedPatterns(convert, k, d);

            return result;
        }

        public List<PairedEulerianNode> ConvertUnifiedPairEulerianNodeToPairedEulerianNode(List<EulerianNode> toBeConverted)
        {
            return toBeConverted.Select(x => new PairedEulerianNode(x.Label.Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries)[0],
                                    x.Label.Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries)[1])).ToList();
        }

        public KeyValuePair<HashSet<EulerianNode>, Dictionary<string, List<EulerianEdge>>> CreatePairedDebruijnFromReadPairs(List<PairedEulerianNode> patterns)
        {
            var allSuffix = patterns.Select(x => x.Suffix + "|" + x.PairedSuffix).Distinct().ToList();
            var allPrefix = patterns.Select(x => x.Prefix + "|" + x.PairedPrefix).Distinct().ToList();

            var returnedNodes = new HashSet<EulerianNode>();
            var returnedEdges = new Dictionary<string, List<EulerianEdge>>();

            var combined = new List<string>();
            combined.AddRange(allPrefix);
            combined.AddRange(allSuffix);
            combined = combined.Distinct().ToList();
            
            foreach (var n in patterns)
            {
                EulerianNode tempFromNode = null;
                EulerianNode tempToNode = null;

                var fromLabel = combined.Where(x => x == n.Prefix + "|" + n.PairedPrefix).FirstOrDefault();
                if (returnedNodes.Any(r => r.Label == fromLabel))
                {
                    tempFromNode = returnedNodes.Where(r => r.Label == fromLabel).FirstOrDefault();
                }
                else
                {
                    tempFromNode = new EulerianNode(fromLabel);
                    returnedNodes.Add(tempFromNode);
                }

                var toLabel = combined.Where(x => x == n.Suffix + "|" + n.PairedSuffix).FirstOrDefault();
                if (returnedNodes.Any(r => r.Label == toLabel))
                {
                    tempToNode = returnedNodes.Where(r => r.Label == toLabel).FirstOrDefault();
                }
                else
                {
                    tempToNode = new EulerianNode(toLabel);
                    returnedNodes.Add(tempToNode);
                }

                var edgesDictionaryKey = fromLabel;
                if (returnedEdges.ContainsKey(edgesDictionaryKey))
                {
                    var existing = returnedEdges[edgesDictionaryKey];
                    if (!tempFromNode.OutgoingLabel.Contains(tempToNode.Label))
                    {
                        tempFromNode.OutgoingLabel.Add(tempToNode.Label);
                    }
                    if (!tempToNode.IncomingLabel.Contains(tempFromNode.Label))
                    {
                        tempToNode.IncomingLabel.Add(tempFromNode.Label);
                    }
                    existing.Add(new EulerianEdge(tempFromNode, tempToNode));
                }
                else
                {
                    var newValue = new List<EulerianEdge>();
                    newValue.Add(new EulerianEdge(tempFromNode, tempToNode));
                    if (!tempFromNode.OutgoingLabel.Contains(tempToNode.Label))
                    {
                        tempFromNode.OutgoingLabel.Add(tempToNode.Label);
                    }
                    if (!tempToNode.IncomingLabel.Contains(tempFromNode.Label))
                    {
                        tempToNode.IncomingLabel.Add(tempFromNode.Label);
                    }
                    returnedEdges.Add(edgesDictionaryKey, newValue);
                }
            }

            return new KeyValuePair<HashSet<EulerianNode>, Dictionary<string, List<EulerianEdge>>>(returnedNodes, returnedEdges);
        }

        public string StringSpelledByGappedPatterns(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var k = 0;
            var d = 0;

            var nodesList = new List<PairedEulerianNode>();
            for(int i = 0; i < fileLines.Length; i++)
            {
                if (i == 0)
                {
                    var ints = fileLines[i].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    k = Convert.ToInt32(ints[0]);
                    d = Convert.ToInt32(ints[1]);
                }
                else
                {
                    var patterns = fileLines[i].Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                    var firstPattern = patterns[0];
                    var terminalPattern = patterns[1];
                    var newNode = new PairedEulerianNode(firstPattern, terminalPattern);
                    nodesList.Add(newNode);
                }
            }

            return StringSpelledByGappedPatterns(nodesList, k, d);
        }

        public string StringSpelledByGappedPatterns(List<PairedEulerianNode> pairedNodes, int k, int d)
        {
            var firstPatterns = pairedNodes.Select(pn => pn.Label).ToList();
            var terminalPatterns = pairedNodes.Select(pn => pn.PairedLabel).ToList();
            var prefixString = GenomePathStringReconstructionLogic(firstPatterns);
            var suffixString = GenomePathStringReconstructionLogic(terminalPatterns);
            
            for (int i = k + d; i < prefixString.Length; i++)
            {
                if (prefixString[i] != suffixString[i - k - d])
                {
                    return "there is no string spelled by the gapped patterns";
                }
            }
            var suffixIndex = suffixString.Length - k - d;

            return prefixString + suffixString.Substring(suffixIndex, k + d);
        }

        public string ConstructUniversalStrings(int length)
        {
            // first generate all patterns
            var patterns = GenerateUniversalStringPatterns(length);

            var debruijnAdjacencyObject = CreateDeBruijnGraphFromPatternsLogic(patterns);
            var eulerianNodes = GetEulerianNodesFromDebruijnAdjacency(debruijnAdjacencyObject);
            var eulerianEdges = GetEulerianEdgesFromDebruijnAdjacency(debruijnAdjacencyObject);

            var currentCycle = ConstructEulerianCycleFromAdjacenciesLogic(eulerianNodes, eulerianEdges);
            var returnedString = ConstructPatternFromEulerianNodes(currentCycle);

            // cut last three characters
            returnedString = returnedString.Substring(0, returnedString.Length - length + 1);

            return returnedString;
        }
        
        public List<string> GenerateUniversalStringPatterns(int length)
        {
            var patterns = new List<string>();
            for (int i = 0; i < Math.Pow(2, length); i++)
            {
                patterns.Add(Convert.ToString(i, 2).PadLeft(length, '0'));
            }
            return patterns;
        }

        public string ConstructEulerianPathFromPatterns(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var lines = new List<string>();

            var k = 0;

            for (int i = 0; i < fileLines.Count(); i++)
            {
                var t = fileLines[i];
                if (i == 0)
                {
                    k = Convert.ToInt32(t.Trim());
                }
                else
                {
                    if (!string.IsNullOrEmpty(t))
                    {
                        lines.Add(t.Trim());
                    }
                }
            }

            var debruijnAdjacencyObject = CreateDeBruijnGraphFromPatternsLogic(lines);

            var eulerianNodes = GetEulerianNodesFromDebruijnAdjacency(debruijnAdjacencyObject);
            var eulerianEdges = GetEulerianEdgesFromDebruijnAdjacency(debruijnAdjacencyObject);

            var currentCycle = ConstructEulerianPathFromAdjacenciesLogic(eulerianNodes, eulerianEdges);
            //var cycleNodesArray = currentCycle.Select(x => x.Label);
            var returnedString = ConstructPatternFromEulerianNodes(currentCycle);

            return returnedString;
        }

        public string ConstructPatternFromEulerianNodes(List<EulerianNode> nodes)
        {
            var constructedString = new StringBuilder();
            for(int i = 0; i < nodes.Count; i++)
            {
                if (i == 0)
                {
                    constructedString.Append(nodes[i].Label);
                }
                else
                {
                    constructedString.Append(nodes[i].Label.Substring(nodes[i].Label.Length - 1, 1));
                }
            }
            return constructedString.ToString();
        }

        public Dictionary<string, List<EulerianEdge>> GetEulerianEdgesFromDebruijnAdjacency(List<DeBruijnAdjacencyObject> adjacencies)
        {
            var returnedDictionary = new Dictionary<string, List<EulerianEdge>>();

            foreach(var eo in adjacencies)
            {
                var key = eo.FromNode.Pattern;
                var fromNode = new EulerianNode(eo.FromNode.Pattern);
                var value = new List<EulerianEdge>();
                foreach(var tn in eo.ToNodes)
                {
                    var toNode = new EulerianNode(tn.Pattern);
                    value.Add(new EulerianEdge(fromNode, toNode));
                }            
                if (!returnedDictionary.ContainsKey(key))
                {
                    returnedDictionary.Add(key, value);
                }
                else
                {
                    returnedDictionary[key].AddRange(value);
                }
            }
            return returnedDictionary;
        }

        public HashSet<EulerianNode> GetEulerianNodesFromDebruijnAdjacency(List<DeBruijnAdjacencyObject> adjacencies)
        {
            var returnedSet = new HashSet<EulerianNode>();

            foreach(var eo in adjacencies)
            {
                // from
                var startNode = eo.FromNode;
                EulerianNode candidateEulerianNode = null;
                if (returnedSet.Any(x => x.Label == eo.FromNode.Pattern))
                {
                    candidateEulerianNode = returnedSet.Where(x => x.Label == eo.FromNode.Pattern).FirstOrDefault();
                }
                else
                {
                    candidateEulerianNode = new EulerianNode(eo.FromNode.Pattern);
                }
                foreach(var tn in eo.ToNodes)
                {
                    EulerianNode anotherCandidateEulerianNode = null;
                    if (returnedSet.Any(x => x.Label == tn.Pattern))
                    {
                        anotherCandidateEulerianNode = returnedSet.Where(x => x.Label == tn.Pattern).FirstOrDefault();
                    }
                    else
                    {
                        anotherCandidateEulerianNode = new EulerianNode(tn.Pattern);
                    }
                    // incoming
                    anotherCandidateEulerianNode.IncomingLabel.Add(eo.FromNode.Pattern);

                    // outgoing
                    candidateEulerianNode.OutgoingLabel.Add(tn.Pattern);
                                        
                    if (!returnedSet.Any(x => x.Label == anotherCandidateEulerianNode.Label))
                    {
                        returnedSet.Add(anotherCandidateEulerianNode);
                    }
                }
                if (!returnedSet.Any(x => x.Label == candidateEulerianNode.Label))
                {
                    returnedSet.Add(candidateEulerianNode);
                }
            }

            return returnedSet;
        }

        public string ConstructEulerianPathFromAdjacencies(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var lines = new List<string>();

            var allNodes = new HashSet<EulerianNode>();
            var allEdges = new HashSet<EulerianEdge>();

            foreach (var l in fileLines)
            {
                if (!string.IsNullOrEmpty(l))
                {
                    // split by ->
                    var split = l.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                    // first one is always one
                    var firstNodeLabel = split[0].Trim();

                    EulerianNode fromNode = null;
                    if (!allNodes.Any(n => n.Label == firstNodeLabel))
                    {
                        fromNode = new EulerianNode(firstNodeLabel);
                        allNodes.Add(fromNode);
                    }
                    else
                    {
                        fromNode = allNodes.Where(n => n.Label == firstNodeLabel).FirstOrDefault();
                    }

                    // second one needs to be split by "," again
                    var secondSplit = split[1].Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    var adjacentLabels = secondSplit.Select(x => x.Trim()).ToList();
                    foreach (var al in adjacentLabels)
                    {
                        if (!fromNode.OutgoingLabel.Contains(al))
                        {
                            fromNode.OutgoingLabel.Add(al);
                        }

                        EulerianNode toNode = null;
                        
                        if (!allNodes.Any(n => n.Label == al))
                        {
                            toNode = new EulerianNode(al);
                            allNodes.Add(toNode);
                        }
                        else
                        {
                            toNode = allNodes.Where(n => n.Label == al).FirstOrDefault();
                        }

                        if (!toNode.IncomingLabel.Contains(firstNodeLabel))
                        {
                            toNode.IncomingLabel.Add(firstNodeLabel);
                        }

                        var newEdge = new EulerianEdge(fromNode, toNode);
                        if (!allEdges.Contains(newEdge))
                        {
                            allEdges.Add(newEdge);
                        }
                    }
                }
            }

            var combinedEdges = new Dictionary<string, List<EulerianEdge>>();
            foreach (var e in allEdges)
            {
                if (combinedEdges.ContainsKey(e.From.Label))
                {
                    var existing = combinedEdges[e.From.Label];
                    existing.Add(e);
                }
                else
                {
                    var newList = new List<EulerianEdge> { e };
                    combinedEdges.Add(e.From.Label, newList);
                }
            }

            var currentCycle = ConstructEulerianPathFromAdjacenciesLogic(allNodes, combinedEdges);
            var cycleNodesArray = currentCycle.Select(x => x.Label);
            var returnedString = string.Join("->", cycleNodesArray);

            return returnedString;
        }

        public List<EulerianNode> ConstructEulerianPathFromAdjacenciesLogic2(HashSet<EulerianNode> nodes, Dictionary<string, List<EulerianEdge>> edges)
        {
            // should be same as cycle, but start from a node that has more outgoing than incoming
            // list of nodes with unused edges
            var unusedNodes = new List<EulerianNode>();
            var totalEdgesCount = edges.Values.Sum(x => x.Count);

            // current cycle
            var currentCycle = new List<EulerianNode>();

            // construct first cycle, by picking the node with more incoming, and then add edge to connect it to the node with more outgoing than incoming
            var randomIndex = new Random();

            // find node with more incoming
            var destinationNode = nodes.Where(n => n.OutgoingLabel.Count < n.IncomingLabel.Count).MinBy(x => x.OutgoingLabel.Count);
            // find node with more outgoing
            var startingNode = nodes.Where(n => n.OutgoingLabel.Count > n.IncomingLabel.Count).MinBy(x => x.IncomingLabel.Count);
            // add this edge
            var balancingEdge = new EulerianEdge(destinationNode, startingNode);
            if (!edges.ContainsKey(destinationNode.Label))
            {
                edges.Add(destinationNode.Label, new List<EulerianEdge>() { balancingEdge });
            }
            else
            {
                edges[destinationNode.Label].Add(balancingEdge);
            }
            // and now let's be off from here
            EulerianNode firstNode = startingNode;

            //currentCycle.Add(firstNode);
            var currentNode = firstNode;
            EulerianNode nextNode = null;
            while (!firstNode.Equals(nextNode))
            {
                if (!edges.ContainsKey(currentNode.Label))
                {
                    break;
                }
                var edgesInThisNode = edges[currentNode.Label];

                // pick first one, as random
                var pickedEdge = edgesInThisNode.FirstOrDefault();
                nextNode = new EulerianNode(pickedEdge.To.Label);
                currentCycle.Add(nextNode);

                if (edgesInThisNode.Count > 1)
                {
                    // there are multiple edges
                    unusedNodes.Add(currentNode);

                    // remove already used edge
                    edgesInThisNode.Remove(pickedEdge);
                }
                else if (edgesInThisNode.Count == 1)
                {
                    // remove this node from unused nodes too
                    edges.Remove(currentNode.Label);
                    unusedNodes.Remove(currentNode);
                }

                currentNode = nextNode;
            }

            while (edges.Count > 0 && unusedNodes.Count > 0)
            {
                totalEdgesCount = edges.Values.Sum(x => x.Count);
                // pick first node with unused edge
                var newStartingNode = unusedNodes.ElementAt(randomIndex.Next(unusedNodes.Count));
                // then clear unusedNodes
                unusedNodes.Remove(newStartingNode);

                // reorder cycle to start at this new starting node
                var newStartingNodeIndex = currentCycle.IndexOf(newStartingNode);
                if (newStartingNodeIndex == currentCycle.Count)
                {
                    newStartingNodeIndex = 0;
                }
                currentCycle = currentCycle.Circle(newStartingNodeIndex + 1).ToList();

                // now repeat cycle algorithm
                var repeatCurrentNode = newStartingNode;
                EulerianNode repeatNextNode = null;
                while (!newStartingNode.Equals(repeatNextNode))
                {
                    if (!edges.ContainsKey(repeatCurrentNode.Label))
                    {
                        unusedNodes.Remove(repeatCurrentNode);
                        break;
                    }
                    var edgesInThisNode = edges[repeatCurrentNode.Label];

                    // pick first one, as random
                    var pickedEdge = edgesInThisNode.FirstOrDefault();
                    repeatNextNode = new EulerianNode(pickedEdge.To.Label);
                    currentCycle.Add(repeatNextNode);

                    if (edgesInThisNode.Count > 1)
                    {
                        // there are multiple edges
                        unusedNodes.Add(repeatCurrentNode);

                        // remove already used edge
                        edgesInThisNode.Remove(pickedEdge);
                    }
                    else if (edgesInThisNode.Count == 1)
                    {
                        edges.Remove(repeatCurrentNode.Label);
                        unusedNodes.Remove(repeatCurrentNode);
                    }

                    repeatCurrentNode = repeatNextNode;
                }
            }

            // now rearrange, find index of destination node
            var endingIndex = currentCycle.IndexOf(destinationNode);
            if (endingIndex == currentCycle.Count)
            {
                endingIndex = 0;
            }
            currentCycle = currentCycle.Circle(endingIndex + 1).ToList();

            return currentCycle;
        }

        public List<EulerianNode> ConstructEulerianPathFromAdjacenciesLogic(HashSet<EulerianNode> nodes, Dictionary<string, List<EulerianEdge>> edges)
        {
            // should be same as cycle, but start from a node that has more outgoing than incoming
            // list of nodes with unused edges
            var unusedNodes = new List<EulerianNode>();
            var totalEdgesCount = edges.Values.Sum(x => x.Count);

            // current cycle
            var currentCycle = new List<EulerianNode>();

            // construct first cycle, by picking the node with more incoming, and then add edge to connect it to the node with more outgoing than incoming
            var randomIndex = new Random();

            // find node with more incoming
            var destinationNode = nodes.Where(n => n.OutgoingLabel.Count > n.IncomingLabel.Count).FirstOrDefault();
            // find node with more outgoing
            var startingNode = nodes.Where(n => n.OutgoingLabel.Count < n.IncomingLabel.Count).FirstOrDefault();
            // add this edge
            var balancingEdge = new EulerianEdge(destinationNode, startingNode);
            // and now let's be off from here
            EulerianNode firstNode = destinationNode; 

            currentCycle.Add(firstNode);
            var currentNode = firstNode;
            EulerianNode nextNode = null;
            while (!firstNode.Equals(nextNode))
            {
                if (!edges.ContainsKey(currentNode.Label))
                {
                    break;
                }
                var edgesInThisNode = edges[currentNode.Label];

                // pick first one, as random
                var pickedEdge = edgesInThisNode.FirstOrDefault();
                nextNode = new EulerianNode(pickedEdge.To.Label);
                currentCycle.Add(nextNode);

                if (edgesInThisNode.Count > 1)
                {
                    // there are multiple edges
                    unusedNodes.Add(currentNode);

                    // remove already used edge
                    edgesInThisNode.Remove(pickedEdge);
                }
                else if (edgesInThisNode.Count == 1)
                {
                    // remove this node from unused nodes too
                    edges.Remove(currentNode.Label);
                    unusedNodes.Remove(currentNode);
                }

                currentNode = nextNode;
            }

            while (edges.Count > 0)
            {
                totalEdgesCount = edges.Values.Sum(x => x.Count);
                // pick first node with unused edge
                var newStartingNode = unusedNodes.ElementAt(randomIndex.Next(unusedNodes.Count));
                // then clear unusedNodes
                unusedNodes.Remove(newStartingNode);

                // reorder cycle to start at this new starting node
                var newStartingNodeIndex = currentCycle.IndexOf(newStartingNode);
                if (newStartingNodeIndex == currentCycle.Count)
                {
                    newStartingNodeIndex = 0;
                }
                currentCycle = currentCycle.Circle(newStartingNodeIndex + 1).ToList();

                // now repeat cycle algorithm
                var repeatCurrentNode = newStartingNode;
                EulerianNode repeatNextNode = null;
                while (!newStartingNode.Equals(repeatNextNode))
                {
                    if (!edges.ContainsKey(repeatCurrentNode.Label))
                    {
                        unusedNodes.Remove(repeatCurrentNode);
                        break;
                    }
                    var edgesInThisNode = edges[repeatCurrentNode.Label];

                    // pick first one, as random
                    var pickedEdge = edgesInThisNode.FirstOrDefault();
                    repeatNextNode = new EulerianNode(pickedEdge.To.Label);
                    currentCycle.Add(repeatNextNode);

                    if (edgesInThisNode.Count > 1)
                    {
                        // there are multiple edges
                        unusedNodes.Add(repeatCurrentNode);

                        // remove already used edge
                        edgesInThisNode.Remove(pickedEdge);
                    }
                    else if (edgesInThisNode.Count == 1)
                    {
                        edges.Remove(repeatCurrentNode.Label);
                        unusedNodes.Remove(repeatCurrentNode);
                    }

                    repeatCurrentNode = repeatNextNode;
                }
            }

            // now rearrange, find index of destination node
            var endingIndex = currentCycle.IndexOf(destinationNode);
            if (endingIndex == currentCycle.Count)
            {
                endingIndex = 0;
            }
            currentCycle = currentCycle.Circle(endingIndex).ToList();

            return currentCycle;
        }

        public void Log(string input)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                w.WriteLine(input);
            }
        }

        public void TestEulerianCycle(string inputFile, List<EulerianNode> target)
        {
            // reprocess input again
            var fileLines = File.ReadAllLines(inputFile);
            var lines = new List<string>();

            var allNodes = new HashSet<EulerianNode>();
            var allEdges = new HashSet<EulerianEdge>();

            foreach (var l in fileLines)
            {
                if (!string.IsNullOrEmpty(l))
                {
                    // split by ->
                    var split = l.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                    // first one is always one
                    var firstNodeLabel = split[0].Trim();

                    var fromNode = new EulerianNode(firstNodeLabel);
                    if (!allNodes.Contains(fromNode))
                    {
                        allNodes.Add(fromNode);
                    }

                    // second one needs to be split by "," again
                    var secondSplit = split[1].Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    var adjacentLabels = secondSplit.Select(x => x.Trim()).ToList();
                    foreach (var al in adjacentLabels)
                    {
                        var toNode = new EulerianNode(al);
                        var newEdge = new EulerianEdge(fromNode, toNode);
                        if (!allEdges.Contains(newEdge))
                        {
                            allEdges.Add(newEdge);
                        }
                    }
                }
            }

            var combinedEdges = new Dictionary<string, List<EulerianEdge>>();
            foreach (var e in allEdges)
            {
                if (combinedEdges.ContainsKey(e.From.Label))
                {
                    var existing = combinedEdges[e.From.Label];
                    existing.Add(e);
                }
                else
                {
                    var newList = new List<EulerianEdge> { e };
                    combinedEdges.Add(e.From.Label, newList);
                }
            }

            var cycleNodesArray = target.Select(x => x.Label);
            var returnedString = string.Join("->", cycleNodesArray);
            // traverse now, removing edges as we go
            for (int i = 0; i < target.Count; i++)
            {
                if (i == target.Count - 1)
                {
                    if(combinedEdges.Count > 0)
                    {
                        throw new Exception("WRONG");
                    }
                    else
                    {
                        break;
                    }
                }
                var currentNode = target[i];
                if (currentNode.Label == "1765")
                {
                    var x = "";
                }
                var edgesInThisNode = combinedEdges[currentNode.Label];
                EulerianEdge pickedEdge = null;
                if (i < target.Count - 1)
                {
                    pickedEdge = edgesInThisNode.Where(x => x.To.Label == target[i + 1].Label).FirstOrDefault();
                }
                else
                {
                    pickedEdge = edgesInThisNode.Where(x => x.To.Label == target[0].Label).FirstOrDefault();
                }

                if (pickedEdge == null)
                {
                    var t = "wut";
                }

                if (edgesInThisNode.Count > 1)
                {
                    // remove already used edge
                    edgesInThisNode.Remove(pickedEdge);
                }
                else if (edgesInThisNode.Count == 1)
                {
                    // remove this node from unused nodes too
                    combinedEdges.Remove(currentNode.Label);
                }
            }
        }

        public string ConstructEulerianCycleFromAdjacencies(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var lines = new List<string>();

            var allNodes = new HashSet<EulerianNode>();
            var allEdges = new HashSet<EulerianEdge>();

            foreach (var l in fileLines)
            {
                if (!string.IsNullOrEmpty(l))
                {
                    // split by ->
                    var split = l.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                    // first one is always one
                    var firstNodeLabel = split[0].Trim();

                    var fromNode = new EulerianNode(firstNodeLabel);
                    if (!allNodes.Contains(fromNode))
                    {
                        allNodes.Add(fromNode);
                    }

                    // second one needs to be split by "," again
                    var secondSplit = split[1].Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    var adjacentLabels = secondSplit.Select(x => x.Trim()).ToList();
                    foreach(var al in adjacentLabels)
                    {
                        var toNode = new EulerianNode(al);
                        var newEdge = new EulerianEdge(fromNode, toNode);
                        if (!allEdges.Contains(newEdge))
                        {
                            allEdges.Add(newEdge);
                        }
                    }                    
                }
            }

            var combinedEdges = new Dictionary<string, List<EulerianEdge>>();
            foreach (var e in allEdges)
            {
                if (combinedEdges.ContainsKey(e.From.Label))
                {
                    var existing = combinedEdges[e.From.Label];
                    existing.Add(e);
                }
                else
                {
                    var newList = new List<EulerianEdge> { e };
                    combinedEdges.Add(e.From.Label, newList);
                }
            }

            var currentCycle = ConstructEulerianCycleFromAdjacenciesLogic(allNodes, combinedEdges);
            var cycleNodesArray = currentCycle.Select(x => x.Label);
            var returnedString = string.Join("->", cycleNodesArray);

            TestEulerianCycle(inputFile, currentCycle);

            return returnedString;
        }

        public List<EulerianNode> ConstructEulerianCycleFromAdjacenciesLogic(HashSet<EulerianNode> nodes, Dictionary<string, List<EulerianEdge>> edges)
        {
            // list of nodes with unused edges
            var unusedNodes = new List<EulerianNode>();
            var totalEdgesCount = edges.Values.Sum(x => x.Count);

            // current cycle
            var currentCycle = new List<EulerianNode>();

            // construct first random cycle
            var randomIndex = new Random();
            var firstNode = nodes.ElementAt(randomIndex.Next(nodes.Count));
            //currentCycle.Add(firstNode);
            var currentNode = firstNode;
            EulerianNode nextNode = null;
            while (!firstNode.Equals(nextNode))
            {
                var edgesInThisNode = edges[currentNode.Label];

                // pick first one, as random
                var pickedEdge = edgesInThisNode.FirstOrDefault();
                nextNode = new EulerianNode(pickedEdge.To.Label);                
                currentCycle.Add(nextNode);                

                if (edgesInThisNode.Count > 1)
                {
                    // there are multiple edges
                    unusedNodes.Add(currentNode);

                    // remove already used edge
                    edgesInThisNode.Remove(pickedEdge);
                }
                else if (edgesInThisNode.Count == 1)
                {
                    // remove this node from unused nodes too
                    edges.Remove(currentNode.Label);
                    unusedNodes.Remove(currentNode);
                }

                currentNode = nextNode;
            }

            while(edges.Count > 0)
            {
                totalEdgesCount = edges.Values.Sum(x => x.Count);
                // pick first node with unused edge
                var newStartingNode = unusedNodes.ElementAt(randomIndex.Next(unusedNodes.Count));
                // then clear unusedNodes
                unusedNodes.Remove(newStartingNode);

                // reorder cycle to start at this new starting node
                var newStartingNodeIndex = currentCycle.IndexOf(newStartingNode);
                if (newStartingNodeIndex == currentCycle.Count)
                {
                    newStartingNodeIndex = 0;
                }
                currentCycle = currentCycle.Circle(newStartingNodeIndex + 1).ToList();

                // now repeat cycle algorithm
                var repeatCurrentNode = newStartingNode;
                EulerianNode repeatNextNode = null;
                while (!newStartingNode.Equals(repeatNextNode))
                {
                    if (!edges.ContainsKey(repeatCurrentNode.Label))
                    {
                        unusedNodes.Remove(repeatCurrentNode);
                        break;
                    }
                    var edgesInThisNode = edges[repeatCurrentNode.Label];

                    // pick first one, as random
                    var pickedEdge = edgesInThisNode.FirstOrDefault();
                    repeatNextNode = new EulerianNode(pickedEdge.To.Label);
                    currentCycle.Add(repeatNextNode);
                    //if (!repeatNextNode.Equals(newStartingNode))
                    //{
                    //    currentCycle.Add(repeatNextNode);
                    //}

                    if (edgesInThisNode.Count > 1)
                    {
                        // there are multiple edges
                        unusedNodes.Add(repeatCurrentNode);

                        // remove already used edge
                        edgesInThisNode.Remove(pickedEdge);
                    }
                    else if (edgesInThisNode.Count == 1)
                    {
                        edges.Remove(repeatCurrentNode.Label);
                        unusedNodes.Remove(repeatCurrentNode);
                    }

                    repeatCurrentNode = repeatNextNode;
                }
            }

            // just add last node to complete the cycle
            currentCycle.Add(currentCycle.First());

            return currentCycle;
        }

        // first week ends

        public List<string> CreateDeBruijnGraphFromPatterns(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var lines = new List<string>();

            foreach (var i in fileLines)
            {
                if (!string.IsNullOrEmpty(i))
                {
                    lines.Add(i.Trim());
                }
            }

            return CreateDeBruijnGraphFromPatternsLogic(lines).Select(x => x.ToString()).OrderBy(s => s).ToList();
        }

        public List<DeBruijnAdjacencyObject> CreateDeBruijnGraphFromPatternsLogic(List<string> patterns)
        {
            var representAsNodes = patterns.Select(x => new OverlapNode(x));

            var allSuffix = representAsNodes.Select(x => x.Prefix).Distinct().ToList();
            var allPrefix = representAsNodes.Select(x => x.Suffix).Distinct().ToList();

            var combined = new List<string>();
            combined.AddRange(allPrefix);
            combined.AddRange(allSuffix);
            combined = combined.Distinct().ToList();

            var fixsAsNodes = combined.Select(x => new OverlapNode(x));

            var returnedList = new List<DeBruijnAdjacencyObject>();

            foreach(var p in representAsNodes)
            {
                var tempFromNode = new OverlapNode(combined.Where(x => x == p.Prefix).FirstOrDefault());
                var tempToNode = new OverlapNode(combined.Where(x => x == p.Suffix).FirstOrDefault());

                if (returnedList.Any(x => x.FromNode.Pattern == tempFromNode.Pattern))
                {
                    var existing = returnedList.Where(x => x.FromNode.Pattern == tempFromNode.Pattern).FirstOrDefault();
                    existing.ToNodes.Add(tempToNode);
                }
                else
                {
                    returnedList.Add(new DeBruijnAdjacencyObject(tempFromNode, new List<OverlapNode>() { tempToNode }));
                }
            }

            return returnedList;
        }

        public List<string> CreateDeBruijnGraph(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);

            var k = 0;
            var text = "";

            for (var i = 0; i < fileLines.Length; i++)
            {
                if (i == 0)
                {
                    k = Convert.ToInt32(fileLines[i]);
                }
                if (i == 1)
                {
                    text = fileLines[i].Trim();
                }
            }

            return CreateDeBruijnGraphLogic(k, text).Select(x => x.ToString()).OrderBy(s => s).ToList();
        }
        
        public List<DeBruijnAdjacencyObject> CreateDeBruijnGraphLogic(int k, string text)
        {
            var adjacencies = new List<OverlapAdjacencyObject>();
            var deBruijnAdjacencies = new List<DeBruijnAdjacencyObject>();

            for(int i = 0; i < text.Length - k + 1; i++)
            {
                adjacencies.Add(
                    new OverlapAdjacencyObject(
                        new OverlapNode(text.Substring(i, k - 1)), 
                        new OverlapNode(text.Substring(i + 1, k - 1))));
            }

            foreach(var a in adjacencies)
            {
                // first check if it exists
                if (deBruijnAdjacencies.Any(dbn => dbn.FromNode.Pattern == a.FromNode.Pattern))
                {
                    continue;
                }

                // this is where we merge
                var duplicateFromNode = adjacencies.Where(x => x.FromNode.Pattern == a.FromNode.Pattern).ToList();

                deBruijnAdjacencies.Add(new DeBruijnAdjacencyObject(a.FromNode, duplicateFromNode.Select(x => x.ToNode).ToList()));
            }

            return deBruijnAdjacencies;
        }
        
        public List<string> CreateOverlapAdjacencyList(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var lines = new List<string>();

            foreach (var i in fileLines)
            {
                if (!string.IsNullOrEmpty(i))
                {
                    lines.Add(i.Trim());
                }
            }

            return CreateOverlapAdjacencyListLogic(lines).Select(x => x.ToString()).OrderBy(s => s).ToList();
        }

        public List<OverlapAdjacencyObject> CreateOverlapAdjacencyListLogic(List<string> patterns)
        {
            var listOfNodes = CreateOverlapNodes(patterns);
            var adjacencies = new List<OverlapAdjacencyObject>();

            foreach(var n in listOfNodes)
            {
                var nextNodes = listOfNodes.Where(x => x.Prefix == n.Suffix).ToList();
                foreach(var d in nextNodes)
                {
                    adjacencies.Add(new OverlapAdjacencyObject(n, d));
                }
            }

            return adjacencies;
        }

        public List<OverlapNode> CreateOverlapNodes(List<string> patterns)
        {
            var r = new List<OverlapNode>();
            foreach(var s in patterns)
            {
                r.Add(new OverlapNode(s));
            }
            return r;
        }

        public string GenomePathStringReconstruction(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);
            var lines = new List<string>();

            foreach (var i in fileLines)
            {
                if (!string.IsNullOrEmpty(i))
                {
                    lines.Add(i.Trim());
                }
            }

            return GenomePathStringReconstructionLogic(lines);
        }

        public string GenomePathStringReconstructionLogic(List<string> inputs)
        {
            var sb = new StringBuilder();

            foreach (var s in inputs)
            {
                if (sb.Length == 0)
                {
                    sb.Append(s);
                }
                else
                {
                    sb.Append(s.Substring(s.Length - 1, 1));
                }
            }

            return sb.ToString();
        }

        public List<string> CreateComposition(string inputFile)
        {
            var fileLines = File.ReadAllLines(inputFile);

            var k = 0;
            var text = "";

            for (var i = 0; i < fileLines.Length; i++)
            {
                if (i == 0)
                {
                    k = Convert.ToInt32(fileLines[i]);
                }
                if (i == 1)
                {
                    text = fileLines[i].Trim();
                }
            }

            return CreateCompositionLogic(k, text);
        }

        public List<string> CreateCompositionLogic(int k, string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return new List<string>();
            }

            var container = new List<string>();
            for (var i = 0; i < text.Length - k + 1; i++)
            {
                container.Add(text.Substring(i, k));
            }
            container.Sort();
            return container;
        }
    }

    public class OverlapNode : IEqualityComparer<OverlapNode>, IEquatable<OverlapNode>
    {
        public string Pattern { get; set;}
        public string Prefix { get; set; }
        public string Suffix { get; set; }

        public OverlapNode(string pattern)
        {
            Pattern = pattern;
            Prefix = pattern.Substring(0, pattern.Length - 1);
            Suffix = pattern.Substring(1, pattern.Length - 1);
        }

        public bool Equals(OverlapNode x, OverlapNode y)
        {
            return x.Pattern == y.Pattern;
        }

        public int GetHashCode(OverlapNode obj)
        {
            return obj.Pattern.GetHashCode();
        }

        public bool Equals(OverlapNode other)
        {
            if (other == null) return false;
            return Pattern == other.Pattern;
        }
    }

    public class OverlapAdjacencyObject
    {
        public OverlapNode FromNode { get; set; }
        public OverlapNode ToNode { get; set; }

        public OverlapAdjacencyObject(OverlapNode from, OverlapNode to)
        {
            FromNode = from;
            ToNode = to;
        }

        public override string ToString()
        {
            return FromNode.Pattern + " -> " + ToNode.Pattern;
        }
    }
    
    public class DeBruijnAdjacencyObject : IEqualityComparer<DeBruijnAdjacencyObject>, IEquatable<DeBruijnAdjacencyObject>
    {
        public OverlapNode FromNode { get; set; }
        // these are supposed to be nodes with identical patterns
        public List<OverlapNode> ToNodes { get; set; }
        public string Edge { get; set; }

        public DeBruijnAdjacencyObject(OverlapNode from, List<OverlapNode> tos)
        {
            FromNode = from;
            ToNodes = tos;
            Edge = from.Suffix + tos.First().Pattern.Substring(from.Pattern.Length - 1, 1);
        }

        public override string ToString()
        {
            return FromNode.Pattern + " -> " + string.Join(", ", ToNodes.Select(x => x.Pattern));
        }

        public bool Equals(DeBruijnAdjacencyObject x, DeBruijnAdjacencyObject y)
        {
            return x.FromNode.Equals(y.FromNode) && x.ToNodes.SequenceEqual(y.ToNodes);
        }

        public int GetHashCode(DeBruijnAdjacencyObject obj)
        {
            return (FromNode.Pattern + " -> " + string.Join(", ", ToNodes.Select(x => x.Pattern))).GetHashCode();
        }

        public bool Equals(DeBruijnAdjacencyObject other)
        {
            if (other == null) return false;
            return FromNode.Equals(other.FromNode) && ToNodes.SequenceEqual(other.ToNodes);
        }
    }

    public class EulerianNode : IEqualityComparer<EulerianNode>, IEquatable<EulerianNode>
    {
        public string Label { get; set; }

        public List<string> IncomingLabel { get; set; }
        public List<string> OutgoingLabel { get; set; }

        public EulerianNode(string label)
        {
            IncomingLabel = new List<string>();
            OutgoingLabel = new List<string>();
            Label = label;
        }

        public bool Equals(EulerianNode x, EulerianNode y)
        {
            return x.Label == y.Label;
        }

        public int GetHashCode(EulerianNode obj)
        {
            return obj.Label.GetHashCode();
        }

        public bool Equals(EulerianNode other)
        {
            if (other == null) return false;
            return Label == other.Label;
        }
    }

    public class EulerianEdge : IEqualityComparer<EulerianEdge>, IEquatable<EulerianEdge>
    {
        public EulerianNode From { get; set; }
        public EulerianNode To { get; set; }

        public EulerianEdge(EulerianNode from, EulerianNode to)
        {
            From = from;
            To = to;
        }

        public bool Equals(EulerianEdge x, EulerianEdge y)
        {
            return x.From == y.From && x.To == y.To;
        }

        public int GetHashCode(EulerianEdge obj)
        {
            return (obj.From + " -> " + obj.To).GetHashCode();
        }

        public bool Equals(EulerianEdge other)
        {
            if (other == null) return false;
            return From == other.From && To == other.To;
        }
    }

    public class PairedEulerianNode : IEqualityComparer<PairedEulerianNode>, IEquatable<PairedEulerianNode>
    {
        public string Label { get; set; }
        public string PairedLabel { get; set; }

        public HashSet<string> IncomingLabel { get; set; }
        public HashSet<string> OutgoingLabel { get; set; }

        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string PairedPrefix { get; set; }
        public string PairedSuffix { get; set; }

        public PairedEulerianNode(string label, string pairedLabel)
        {
            IncomingLabel = new HashSet<string>();
            OutgoingLabel = new HashSet<string>();
            Label = label;
            PairedLabel = pairedLabel;
            Prefix = Label.Substring(0, Label.Length - 1);
            Suffix = Label.Substring(1, Label.Length - 1);
            PairedPrefix = PairedLabel.Substring(0, PairedLabel.Length - 1);
            PairedSuffix = PairedLabel.Substring(1, PairedLabel.Length - 1);
        }

        public bool Equals(PairedEulerianNode x, PairedEulerianNode y)
        {
            return x.Label == y.Label && x.PairedLabel == y.PairedLabel;
        }

        public int GetHashCode(PairedEulerianNode obj)
        {
            return (obj.Label + obj.PairedLabel).GetHashCode();
        }

        public bool Equals(PairedEulerianNode other)
        {
            if (other == null) return false;
            return Label == other.Label && PairedLabel == other.PairedLabel;
        }
    }

    public class PairedEulerianEdge : IEqualityComparer<PairedEulerianEdge>, IEquatable<PairedEulerianEdge>
    {
        public PairedEulerianNode From { get; set; }
        public PairedEulerianNode To { get; set; }

        public PairedEulerianEdge(PairedEulerianNode from, PairedEulerianNode to)
        {
            From = from;
            To = to;
        }

        public bool Equals(PairedEulerianEdge x, PairedEulerianEdge y)
        {
            return x.From == y.From && x.To == y.To;
        }

        public int GetHashCode(PairedEulerianEdge obj)
        {
            return (obj.From + " -> " + obj.To).GetHashCode();
        }

        public bool Equals(PairedEulerianEdge other)
        {
            if (other == null) return false;
            return From == other.From && To == other.To;
        }
    }

    public static class CodeExtensions
    {
        public static IEnumerable<T> Circle<T>(this IEnumerable<T> list, int startIndex)
        {
            return list.Skip(startIndex).Concat(list.Take(startIndex));
        }
    }
}
