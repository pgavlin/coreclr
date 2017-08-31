using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_generics_trycatchsimpletype_d_trycatchsimpletype_d_
    {
        [Fact]
        public void _eh_generics_trycatchsimpletype_d_trycatchsimpletype_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\generics\\trycatchsimpletype_d\\trycatchsimpletype_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
