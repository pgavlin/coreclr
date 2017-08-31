using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__il_relrefloc_i1__il_relrefloc_i1_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__il_relrefloc_i1__il_relrefloc_i1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_il_relrefloc_i1\\_il_relrefloc_i1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
