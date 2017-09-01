using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinstgenerics_ro_isinstgenerics_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstgenerics_ro_isinstgenerics_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstgenerics_ro\\isinstgenerics_ro.cmd");
        }
    }
}
