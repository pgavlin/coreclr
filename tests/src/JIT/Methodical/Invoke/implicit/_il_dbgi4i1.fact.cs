using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__il_dbgi4i1__il_dbgi4i1_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_dbgi4i1__il_dbgi4i1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_dbgi4i1\\_il_dbgi4i1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
