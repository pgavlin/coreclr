using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__il_dbgi4u2__il_dbgi4u2_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_dbgi4u2__il_dbgi4u2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_dbgi4u2\\_il_dbgi4u2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
