using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinstboxed_r_isinstboxed_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstboxed_r_isinstboxed_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstboxed_r\\isinstboxed_r.cmd");
        }
    }
}
