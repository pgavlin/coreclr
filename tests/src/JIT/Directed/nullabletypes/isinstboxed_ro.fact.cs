using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinstboxed_ro_isinstboxed_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstboxed_ro_isinstboxed_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstboxed_ro\\isinstboxed_ro.cmd");
        }
    }
}
