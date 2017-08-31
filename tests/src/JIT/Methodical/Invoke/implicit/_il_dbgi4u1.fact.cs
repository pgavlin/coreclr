using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__il_dbgi4u1__il_dbgi4u1_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_dbgi4u1__il_dbgi4u1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_dbgi4u1\\_il_dbgi4u1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
