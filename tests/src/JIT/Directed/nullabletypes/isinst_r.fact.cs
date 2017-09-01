using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinst_r_isinst_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinst_r_isinst_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinst_r\\isinst_r.cmd");
        }
    }
}
