using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Conversions_Boxing_box_unbox01_box_unbox01_
    {
        [OuterLoop]
        [Fact]
        public void _Conversions_Boxing_box_unbox01_box_unbox01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Conversions\\Boxing\\box_unbox01\\box_unbox01.cmd");
        }
    }
}
