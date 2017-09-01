using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_nested_nestedtry_nestedtryfault_d_nestedtryfault_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_nestedtry_nestedtryfault_d_nestedtryfault_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nestedtry\\nestedtryfault_d\\nestedtryfault_d.cmd");
        }
    }
}
