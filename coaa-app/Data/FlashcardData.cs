namespace coaa_app.Data
{
    public class Flashcard
    {
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public string? Details { get; set; }
        public string[]? Tags { get; set; }
        // For term-definition cards
        public string? Term { get; set; }
        public string? Definition { get; set; }
    }

    public class FlashcardActivity
    {
        public string Activity { get; set; }
        public List<Flashcard> Cards { get; set; }
    }

    public static class FlashcardData
    {
        public static List<FlashcardActivity> Week1 = new()
        {
            new FlashcardActivity
            {
                Activity = "1.13.1: First electronic computers",
                Cards = new List<Flashcard>
                {
                    new Flashcard { Question = "What is the abbreviation for what is considered the world's first operational electronic, general-purpose computer?", Answer = "ENIAC", Details = "Electronic Numerical Integrator and Calculator, developed by Eckert and Mauchly.", Tags = new[] { "History", "Hardware" } },
                    new Flashcard { Question = "The ENIAC was developed in the 1940s at the University of ________.", Answer = "Pennsylvania", Details = "Funded by the U.S. Army for computing artillery-firing tables during WWII.", Tags = new[] { "History" } },
                    new Flashcard { Question = "A team including Alan Turing built Colossus to decrypt ________ messages during World War II.", Answer = "German", Details = "Decrypting these messages is estimated to have reduced the war by two years.", Tags = new[] { "History", "Security" } },
                    new Flashcard { Question = "A computer using separate memories for instructions and data is known as a ________ architecture.", Answer = "Harvard", Details = "Named after the Mark-III and Mark-IV computers developed at Harvard.", Tags = new[] { "Architecture" } }
                }
            },
            new FlashcardActivity
            {
                Activity = "1.13.2: Commercial development of computers",
                Cards = new List<Flashcard>
                {
                    new Flashcard { Term = "IBM System/360", Definition = "Product line of computers with varying cost and performance.", Details = "Varying cost from $225k-$1.9M and clock rates of 1.6 MHz to 5.1MHz.", Tags = new[] { "Commercial", "Hardware" } },
                    new Flashcard { Term = "PDP-8", Definition = "Minicomputer", Details = "Smaller and cheaper than counterparts; cost $20,000 in 1965.", Tags = new[] { "Commercial", "Hardware" } },
                    new Flashcard { Term = "Cray-1", Definition = "Supercomputer", Details = "The fastest and most expensive computer in 1976, costing $4,000,000.", Tags = new[] { "Commercial", "Hardware", "Performance" } },
                    new Flashcard { Term = "Intel 4004", Definition = "Microprocessor", Details = "Introduced in 1971, it was the first CPU integrated into a single integrated circuit (IC).", Tags = new[] { "Hardware", "Innovation" } }
                }
            },
            new FlashcardActivity
            {
                Activity = "1.13.3: Personal computers",
                Cards = new List<Flashcard>
                {
                    new Flashcard { Question = "In the 1980s, the ________ was the most popular personal computer.", Answer = "IBM Personal Computer", Details = "Its popularity led to the dominance of Microsoft's operating systems.", Tags = new[] { "Commercial", "History" } },
                    new Flashcard { Question = "True/False: The first personal computers did not come with a pointing device, such as a mouse.", Answer = "True", Details = "Early computers were text-based; the Xerox Alto was an early influencer of GUI and mouse use.", Tags = new[] { "Hardware", "UX" } },
                    new Flashcard { Question = "What was the only nonvolatile storage in the first personal computers?", Answer = "Floppy drives", Details = "Used to retain programs and data when power was removed.", Tags = new[] { "Hardware", "Storage" } }
                }
            },
            new FlashcardActivity
            {
                Activity = "1.13.4: Evaluating performance",
                Cards = new List<Flashcard>
                {
                    new Flashcard { Question = "True/False: Comparing the time required to perform an add instruction is a reliable method to evaluate performance between computers.", Answer = "False", Details = "Execution times became too varied; standard benchmarks using sets of applications are now used.", Tags = new[] { "Performance", "Theory" } },
                    new Flashcard { Question = "If Computer A runs 10 Whetstones/sec and Computer B runs 12 Whetstones/sec, which is faster?", Answer = "Computer B", Details = "Higher iterations per second indicates a faster computer.", Tags = new[] { "Performance", "Benchmarks" } },
                    new Flashcard { Question = "True/False: The SPEC benchmarks change as computers evolve.", Answer = "True", Details = "SPEC2017 is the most recent version; programs like the gcc compiler remain included from earlier versions.", Tags = new[] { "Performance", "Benchmarks" } }
                }
            },
            new FlashcardActivity
            {
                Activity = "2.24.1: Evolution of computer architectures",
                Cards = new List<Flashcard>
                {
                    new Flashcard { Term = "RISC architecture", Definition = "Reduced instruction set computer architecture", Details = "Relies on small, simple instructions. Most current instruction sets employ this model.", Tags = new[] { "Architecture", "Theory" } },
                    new Flashcard { Term = "Load-store architecture", Definition = "Register-register architecture", Details = "Restricts all operands to be in registers. Used by MIPS and ARM.", Tags = new[] { "Architecture" } },
                    new Flashcard { Term = "Accumulator architecture", Definition = "Single register architecture", Details = "Earliest computers used one register (the accumulator) for all arithmetic operations.", Tags = new[] { "Architecture", "History" } },
                    new Flashcard { Term = "Stack architecture", Definition = "No registers architecture", Details = "Operands are transferred onto and off of a stack; common in 1960s HP calculators.", Tags = new[] { "Architecture" } }
                }
            },
            new FlashcardActivity
            {
                Activity = "2.24.3: History of programming languages",
                Cards = new List<Flashcard>
                {
                    new Flashcard { Question = "Developed for use in business settings, ________ employs English vocabulary and punctuation.", Answer = "Cobol", Details = "Short for COmmon Business-Oriented Language.", Tags = new[] { "Software", "Languages" } },
                    new Flashcard { Question = "In the 1970s, Bell Labs built the UNIX operating system using the ________ language.", Answer = "C", Details = "C's popularity grew with UNIX and influenced languages like C++.", Tags = new[] { "Software", "Languages", "History" } },
                    new Flashcard { Question = "________ is currently the most popular language to teach in schools and standard for business data processing.", Answer = "Java", Details = "Initially called Oak; features an improved object-oriented design compared to C++.", Tags = new[] { "Software", "Languages" } }
                }
            },
            new FlashcardActivity
            {
                Activity = "3.11.1: Floating-point",
                Cards = new List<Flashcard>
                {
                    new Flashcard { Question = "True/False: Floating-point hardware was included in the first computers.", Answer = "False", Details = "John von Neumann refused to include it due to increased complexity and memory loss.", Tags = new[] { "Hardware", "Architecture", "History" } },
                    new Flashcard { Question = "True/False: Floating-point hardware became standardized by the late 1950s.", Answer = "False", Details = "Each implementation was different, leading to inconsistent results across different computers.", Tags = new[] { "Hardware", "Standards" } }
                }
            }
        };
    }
}
