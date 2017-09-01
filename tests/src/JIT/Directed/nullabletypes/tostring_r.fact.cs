using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_tostring_r_tostring_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_tostring_r_tostring_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\tostring_r\\tostring_r.cmd");
        }
    }
}
