using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__il_reli4u2__il_reli4u2_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_reli4u2__il_reli4u2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_reli4u2\\_il_reli4u2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
