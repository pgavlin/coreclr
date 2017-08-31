using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Fields_static_equalnull_struct01_static_equalnull_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _Fields_static_equalnull_struct01_static_equalnull_struct01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Fields\\static_equalnull_struct01\\static_equalnull_struct01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
