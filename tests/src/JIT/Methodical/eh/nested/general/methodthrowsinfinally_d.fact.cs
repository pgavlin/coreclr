using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_nested_general_methodthrowsinfinally_d_methodthrowsinfinally_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_general_methodthrowsinfinally_d_methodthrowsinfinally_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\methodthrowsinfinally_d\\methodthrowsinfinally_d.cmd");
        }
    }
}
