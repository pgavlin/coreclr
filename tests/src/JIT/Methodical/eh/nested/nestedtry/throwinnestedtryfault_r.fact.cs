using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_nested_nestedtry_throwinnestedtryfault_r_throwinnestedtryfault_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_nestedtry_throwinnestedtryfault_r_throwinnestedtryfault_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nestedtry\\throwinnestedtryfault_r\\throwinnestedtryfault_r.cmd");
        }
    }
}
