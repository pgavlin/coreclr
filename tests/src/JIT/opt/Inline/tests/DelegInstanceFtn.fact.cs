using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_DelegInstanceFtn_DelegInstanceFtn_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_DelegInstanceFtn_DelegInstanceFtn_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\DelegInstanceFtn\\DelegInstanceFtn.cmd");
        }
    }
}
