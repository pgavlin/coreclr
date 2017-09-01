using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _Boxing_gcvariant_gcvariant_
    {
        [Fact]
        public void _Boxing_gcvariant_gcvariant_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\Boxing\\gcvariant\\gcvariant.cmd");
        }
    }
}
