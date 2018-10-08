using System;
using System.Collections.Generic;

public class NucleotideCount
{
    private Dictionary<char, int> nucleotides;
    public NucleotideCount(string sequence)
    {
        nucleotides = new Dictionary<char, int>()
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        foreach(char nucleotide in sequence)
        {
            if (nucleotides.ContainsKey(nucleotide))
                nucleotides[nucleotide] += 1;
            else
                throw new ArgumentException();
        }
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            return nucleotides;
        }
    }
}