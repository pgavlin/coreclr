using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinst2_do_isinst2_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinst2_do_isinst2_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinst2_do\\isinst2_do.cmd");
        }
    }
}
