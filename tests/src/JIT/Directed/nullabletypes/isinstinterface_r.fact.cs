using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinstinterface_r_isinstinterface_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstinterface_r_isinstinterface_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstinterface_r\\isinstinterface_r.cmd");
        }
    }
}
