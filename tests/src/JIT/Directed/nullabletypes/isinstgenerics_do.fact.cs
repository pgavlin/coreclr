using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinstgenerics_do_isinstgenerics_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstgenerics_do_isinstgenerics_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstgenerics_do\\isinstgenerics_do.cmd");
        }
    }
}
