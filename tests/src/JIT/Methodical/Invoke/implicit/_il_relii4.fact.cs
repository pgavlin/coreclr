using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__il_relii4__il_relii4_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_relii4__il_relii4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_relii4\\_il_relii4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
