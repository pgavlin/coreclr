using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_DelegInstanceFtn_DelegInstanceFtn_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_DelegInstanceFtn_DelegInstanceFtn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\DelegInstanceFtn\\DelegInstanceFtn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
