using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_nested_nestedtry_throwinnestedtrycatch_r_throwinnestedtrycatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_nestedtry_throwinnestedtrycatch_r_throwinnestedtrycatch_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nestedtry\\throwinnestedtrycatch_r\\throwinnestedtrycatch_r.cmd");
        }
    }
}
