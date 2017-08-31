using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_sealedclass_sealedclass_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_sealedclass_sealedclass_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\sealedclass\\sealedclass.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
