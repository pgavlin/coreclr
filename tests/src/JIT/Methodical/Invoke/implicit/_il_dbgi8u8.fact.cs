using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__il_dbgi8u8__il_dbgi8u8_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_dbgi8u8__il_dbgi8u8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_dbgi8u8\\_il_dbgi8u8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
