using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _Boxing_vararystress_vararystress_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_vararystress_vararystress_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\Boxing\\vararystress\\vararystress.cmd");
        }
    }
}
