using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinstinterface_ro_isinstinterface_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstinterface_ro_isinstinterface_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstinterface_ro\\isinstinterface_ro.cmd");
        }
    }
}
