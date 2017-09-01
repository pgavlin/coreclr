using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _Boxing_arrcpy_arrcpy_
    {
        [Fact]
        public void _Boxing_arrcpy_arrcpy_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\Boxing\\arrcpy\\arrcpy.cmd");
        }
    }
}
