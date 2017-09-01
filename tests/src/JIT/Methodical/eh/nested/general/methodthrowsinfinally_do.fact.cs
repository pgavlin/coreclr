using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_nested_general_methodthrowsinfinally_do_methodthrowsinfinally_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_general_methodthrowsinfinally_do_methodthrowsinfinally_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\methodthrowsinfinally_do\\methodthrowsinfinally_do.cmd");
        }
    }
}
