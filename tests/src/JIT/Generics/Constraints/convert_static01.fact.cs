using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Constraints_convert_static01_convert_static01_
    {
        [OuterLoop]
        [Fact]
        public void _Constraints_convert_static01_convert_static01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Constraints\\convert_static01\\convert_static01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
