using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinstinterface_do_isinstinterface_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstinterface_do_isinstinterface_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstinterface_do\\isinstinterface_do.cmd");
        }
    }
}
