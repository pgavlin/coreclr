using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinstgenerics_r_isinstgenerics_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstgenerics_r_isinstgenerics_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstgenerics_r\\isinstgenerics_r.cmd");
        }
    }
}
