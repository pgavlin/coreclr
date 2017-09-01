using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinstboxed_do_isinstboxed_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstboxed_do_isinstboxed_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstboxed_do\\isinstboxed_do.cmd");
        }
    }
}
