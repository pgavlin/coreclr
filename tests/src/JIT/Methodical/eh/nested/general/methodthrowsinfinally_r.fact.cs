using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_nested_general_methodthrowsinfinally_r_methodthrowsinfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_general_methodthrowsinfinally_r_methodthrowsinfinally_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\methodthrowsinfinally_r\\methodthrowsinfinally_r.cmd");
        }
    }
}
