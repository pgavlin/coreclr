using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__il_dbgi4u4__il_dbgi4u4_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_dbgi4u4__il_dbgi4u4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_dbgi4u4\\_il_dbgi4u4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
