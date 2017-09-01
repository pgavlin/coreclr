using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinst2_ro_isinst2_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinst2_ro_isinst2_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinst2_ro\\isinst2_ro.cmd");
        }
    }
}
