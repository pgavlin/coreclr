using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Arrays_TypeParameters_Jagged_struct01_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_TypeParameters_Jagged_struct01_struct01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Arrays\\TypeParameters\\Jagged\\struct01\\struct01.cmd");
        }
    }
}
