using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinst_d_isinst_d_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinst_d_isinst_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinst_d\\isinst_d.cmd");
        }
    }
}
