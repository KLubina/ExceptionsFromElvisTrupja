using System;

//tutorial
//tutorial form the first part of this video: https://www.youtube.com/watch?v=nTJcmu5uY7U&list=PL2Q8rFbm-4ru_qCllHPOgkpU8XtO25Wh3&index=28
namespace ExceptionsFromElvisTrupja
{
    public class Program
    {
    static void Main( string[] args )
      {
      try
        {
        int x = 12;
        Console.WriteLine( $"12/0 = {x / 0}" );
        }
      catch (DivideByZeroException ex)
      { 
        Console.WriteLine( ex.Message );
        }
      catch ( Exception ex )
        {
        Console.WriteLine( "This is the Exception" );
        throw;
        }
      finally
        {
        Console.WriteLine( "Finally block message" );
        }

      int positiveNumber = -10;
      if ( positiveNumber <= 0 ) throw new ArgumentException( "The number is not positive" );
      }
    }
}
