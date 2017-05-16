using System;
using System.Linq;
using System.Numerics;

namespace Collatz.Extensions
{
   public static class SequenceStatisticsExtensions
   {
      public static SequenceStatistics GetStatistics(this BigInteger[] @this)
      {
         return new SequenceStatistics(@this);
      }
   }

   public sealed class SequenceStatistics
   {
      public SequenceStatistics(BigInteger[] sequence)
      {
         if(sequence == null)
         {
            throw new ArgumentNullException(nameof(sequence));
         }

         Sequence = sequence;
         Car = sequence[0];
         Even = sequence.Count(_ => _ % 2 == BigInteger.Zero);
         Odd = sequence.Length - Even;
         Maximum = sequence.Max();
      }

      public BigInteger Car { get; }
      public BigInteger[] Sequence { get; }
      public BigInteger Even { get; }
      public BigInteger Odd { get; }
      public BigInteger Maximum { get; }
   }
}