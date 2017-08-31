using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__il_reli4u4__il_reli4u4_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_reli4u4__il_reli4u4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_reli4u4\\_il_reli4u4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
