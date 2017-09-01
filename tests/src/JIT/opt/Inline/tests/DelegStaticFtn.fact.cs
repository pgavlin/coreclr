using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_DelegStaticFtn_DelegStaticFtn_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_DelegStaticFtn_DelegStaticFtn_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\DelegStaticFtn\\DelegStaticFtn.cmd");
        }
    }
}
