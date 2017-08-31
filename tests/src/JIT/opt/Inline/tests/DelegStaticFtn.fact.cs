using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_DelegStaticFtn_DelegStaticFtn_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_DelegStaticFtn_DelegStaticFtn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\DelegStaticFtn\\DelegStaticFtn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
