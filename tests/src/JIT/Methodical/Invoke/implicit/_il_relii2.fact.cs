using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__il_relii2__il_relii2_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_relii2__il_relii2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_relii2\\_il_relii2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
