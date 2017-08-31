using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _Convert_minopts_convu1_minopts_convu1_
    {
        [OuterLoop]
        [Fact]
        public void _Convert_minopts_convu1_minopts_convu1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\Convert\\minopts_convu1\\minopts_convu1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
