using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__il_dbgobjref__il_dbgobjref_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_dbgobjref__il_dbgobjref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_dbgobjref\\_il_dbgobjref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
