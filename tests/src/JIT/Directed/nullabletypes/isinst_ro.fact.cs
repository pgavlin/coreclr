using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinst_ro_isinst_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinst_ro_isinst_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinst_ro\\isinst_ro.cmd");
        }
    }
}
