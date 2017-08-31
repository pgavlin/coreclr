using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_generics_trycatchsimpletype_r_trycatchsimpletype_r_
    {
        [Fact]
        public void _eh_generics_trycatchsimpletype_r_trycatchsimpletype_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\generics\\trycatchsimpletype_r\\trycatchsimpletype_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
